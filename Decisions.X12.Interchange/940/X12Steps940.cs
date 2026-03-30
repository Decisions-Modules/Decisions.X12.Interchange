using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using Decisions.X12.Parsing.Model;
using DecisionsFramework.Design.Flow;

namespace X12Interchange940;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "940")]
public static class X12Steps940
{
    public static Interchange Deserialize940EDI(string document940, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document940, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document940);
                }

                fs.Position = 0;
            }

            interchange = ParseInterchangeWithFallback(fs);
        }

        using (FileStream fs = new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite,
                   FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            interchange.Serialize(fs);
            fs.Position = 0;

            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            overrides.Add(typeof(ISA), nameof(ISA.ISA16), new XmlAttributes { XmlIgnore = true });
            XmlSerializer serializer = new XmlSerializer(typeof(Interchange), overrides);

            using (XmlReader xmlReader = XmlReader.Create(fs,
                       new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
            {
                Interchange? result = (Interchange)serializer.Deserialize(xmlReader,
                    new XmlDeserializationEvents
                    {
                        OnUnknownElement = HandleUnknownElement
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "940")
                    throw new InvalidOperationException("Incorrect document being used. Please use 940");

                Transaction940? tx = result?.FunctionGroup?.Transaction;
                if (tx?.NameAddressLoopForDeserialize != null)
                {
                    tx.NameAddressLoop = tx.NameAddressLoopForDeserialize.ToArray();
                    tx.NameAddressLoopForDeserialize = null;
                }
                if (tx?.AssignedNumberLoopForDeserialize != null)
                {
                    tx.AssignedNumberLoop = tx.AssignedNumberLoopForDeserialize.ToArray();
                    tx.AssignedNumberLoopForDeserialize = null;
                }

                return result;
            }
        }
    }

    private static Decisions.X12.Parsing.Model.Interchange ParseInterchangeWithFallback(Stream stream)
    {
        X12Parser strictParser = new X12Parser(true);
        byte[] ediBytes;

        stream.Position = 0;
        using (MemoryStream copy = new MemoryStream())
        {
            stream.CopyTo(copy);
            ediBytes = copy.ToArray();
        }

        try
        {
            using MemoryStream strictStream = new MemoryStream(ediBytes, writable: false);
            return strictParser.Parse(strictStream);
        }
        catch (TransactionValidationException ex) when (IsRecoverableSpecVariance(ex))
        {
            X12Parser lenientParser = new X12Parser(false);
            using MemoryStream lenientStream = new MemoryStream(ediBytes, writable: false);
            return lenientParser.Parse(lenientStream);
        }
    }

    private static bool IsRecoverableSpecVariance(TransactionValidationException ex)
    {
        return ex.Message.Contains("cannot be identified within the supplied specification", StringComparison.OrdinalIgnoreCase);
    }

    private static void HandleUnknownElement(object obj, XmlElementEventArgs args)
    {
        if (args?.Element?.Name != "Loop")
            return;

        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "0100": // NameAddressLoop940
            {
                Transaction940? transaction = args?.ObjectBeingDeserialized as Transaction940;
                if (transaction == null)
                    break;
                NameAddressLoop940 loop = GetLoopValue<NameAddressLoop940>(args.Element);
                if (transaction.NameAddressLoopForDeserialize == null)
                    transaction.NameAddressLoopForDeserialize = new List<NameAddressLoop940>();
                transaction.NameAddressLoopForDeserialize.Add(loop);
            }
                break;
            case "0300": // AssignedNumberLoop940
            {
                Transaction940? transaction = args?.ObjectBeingDeserialized as Transaction940;
                if (transaction == null)
                    break;
                AssignedNumberLoop940 loop = GetLoopValue<AssignedNumberLoop940>(args.Element);
                if (transaction.AssignedNumberLoopForDeserialize == null)
                    transaction.AssignedNumberLoopForDeserialize = new List<AssignedNumberLoop940>();
                transaction.AssignedNumberLoopForDeserialize.Add(loop);
            }
                break;
        }
    }

    private static TLoop GetLoopValue<TLoop>(XmlElement element)
    {
        using (StringReader stringReader = new StringReader(element.OuterXml))
        using (XmlReader xmlReader = XmlReader.Create(stringReader,
                   new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
        {
            XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
            TLoop? loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
            {
                OnUnknownElement = HandleUnknownElement
            });
            return loop;
        }
    }
}
