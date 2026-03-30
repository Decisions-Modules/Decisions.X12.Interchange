using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using Decisions.X12.Parsing.Model;
using DecisionsFramework.Design.Flow;

namespace X12Interchange856;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "856")]
public static class X12Steps856
{
    public static Interchange Deserialize856EDI(string document856, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document856, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document856);
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

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "856")
                    throw new InvalidOperationException("Incorrect document being used. Please use 856");

                Transaction856? tx = result?.FunctionGroup?.Transaction;
                if (tx?.HlLoopForDeserialize != null)
                {
                    tx.HlLoop = tx.HlLoopForDeserialize.ToArray();
                    tx.HlLoopForDeserialize = null;

                    foreach (HlLoop856 hl in tx.HlLoop)
                        if (hl.NameAddressLoopForDeserialize != null)
                        {
                            hl.NameAddressLoop = hl.NameAddressLoopForDeserialize.ToArray();
                            hl.NameAddressLoopForDeserialize = null;
                        }
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
        if (args?.Element?.Name != "Loop" && args?.Element?.Name != "HierarchicalLoop")
            return;

        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "HL": // HlLoop856
            {
                Transaction856? transaction = args?.ObjectBeingDeserialized as Transaction856;
                if (transaction == null)
                    break;
                HlLoop856 loop = GetLoopValue<HlLoop856>(args.Element);
                if (transaction.HlLoopForDeserialize == null)
                    transaction.HlLoopForDeserialize = new List<HlLoop856>();
                transaction.HlLoopForDeserialize.Add(loop);
            }
                break;
            case "N1": // NameAddressLoop856 within HlLoop856
            {
                HlLoop856? hlLoop = args?.ObjectBeingDeserialized as HlLoop856;
                if (hlLoop == null)
                    break;
                NameAddressLoop856 loop = GetLoopValue<NameAddressLoop856>(args.Element);
                if (hlLoop.NameAddressLoopForDeserialize == null)
                    hlLoop.NameAddressLoopForDeserialize = new List<NameAddressLoop856>();
                hlLoop.NameAddressLoopForDeserialize.Add(loop);
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
