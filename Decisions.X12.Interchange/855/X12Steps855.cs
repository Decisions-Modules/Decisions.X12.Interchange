using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange855;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "855")]
public static class X12Steps855
{
    public static Interchange Deserialize855EDI(string document855, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document855, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document855);
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

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "855")
                    throw new InvalidOperationException("Incorrect document being used. Please use 855");

                Transaction855? tx = result?.FunctionGroup?.Transaction;
                if (tx?.NameAddressLoopForDeserialize != null)
                {
                    tx.NameAddressLoop = tx.NameAddressLoopForDeserialize.ToArray();
                    tx.NameAddressLoopForDeserialize = null;
                }
                if (tx?.LineItemLoopForDeserialize != null)
                {
                    tx.LineItemLoop = tx.LineItemLoopForDeserialize.ToArray();
                    tx.LineItemLoopForDeserialize = null;
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
        catch (Decisions.X12.Parsing.Model.TransactionValidationException ex) when (IsRecoverableSpecVariance(ex))
        {
            X12Parser lenientParser = new X12Parser(false);
            using MemoryStream lenientStream = new MemoryStream(ediBytes, writable: false);
            return lenientParser.Parse(lenientStream);
        }
    }

    private static bool IsRecoverableSpecVariance(Decisions.X12.Parsing.Model.TransactionValidationException ex)
    {
        return ex.Message.Contains("cannot be identified within the supplied specification", StringComparison.OrdinalIgnoreCase);
    }

    private static void HandleUnknownElement(object obj, XmlElementEventArgs args)
    {
        if (args?.Element?.Name != "Loop")
            return;

        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "N1": // NameAddressLoop855
            {
                Transaction855? transaction = args?.ObjectBeingDeserialized as Transaction855;
                if (transaction == null)
                    break;
                NameAddressLoop855 loop = GetLoopValue<NameAddressLoop855>(args.Element);
                if (transaction.NameAddressLoopForDeserialize == null)
                    transaction.NameAddressLoopForDeserialize = new List<NameAddressLoop855>();
                transaction.NameAddressLoopForDeserialize.Add(loop);
            }
                break;
            case "PO1": // LineItemLoop855
            {
                Transaction855? transaction = args?.ObjectBeingDeserialized as Transaction855;
                if (transaction == null)
                    break;
                LineItemLoop855 loop = GetLoopValue<LineItemLoop855>(args.Element);
                if (transaction.LineItemLoopForDeserialize == null)
                    transaction.LineItemLoopForDeserialize = new List<LineItemLoop855>();
                transaction.LineItemLoopForDeserialize.Add(loop);
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
