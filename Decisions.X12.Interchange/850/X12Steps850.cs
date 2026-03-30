using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using Decisions.X12.Parsing.Model;
using DecisionsFramework.Design.Flow;

namespace X12Interchange850;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "850")]
public static class X12Steps850
{
    public static Interchange Deserialize850EDI(string document850, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document850, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document850);
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

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "850")
                    throw new InvalidOperationException("Incorrect document being used. Please use 850");

                Transaction850? tx = result?.FunctionGroup?.Transaction;
                if (tx?.NameAddressLoopForDeserialize != null)
                {
                    tx.NameAddressLoop = tx.NameAddressLoopForDeserialize.ToArray();
                    tx.NameAddressLoopForDeserialize = null;
                }
                if (tx?.POLineItemLoopForDeserialize != null)
                {
                    tx.POLineItemLoop = tx.POLineItemLoopForDeserialize.ToArray();
                    tx.POLineItemLoopForDeserialize = null;
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
            // Some partner-generated 850 docs include optional/non-standard segments in alternate locations.
            // Retry in warning mode so deserialization can continue for downstream processing.
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
            case "N1": // NameAddressLoop850
            {
                Transaction850? transaction = args?.ObjectBeingDeserialized as Transaction850;
                if (transaction == null)
                    break;
                NameAddressLoop850 loop = GetLoopValue<NameAddressLoop850>(args.Element);
                if (transaction.NameAddressLoopForDeserialize == null)
                    transaction.NameAddressLoopForDeserialize = new List<NameAddressLoop850>();
                transaction.NameAddressLoopForDeserialize.Add(loop);
            }
                break;
            case "PO1": // POLineItemLoop850
            {
                Transaction850? transaction = args?.ObjectBeingDeserialized as Transaction850;
                if (transaction == null)
                    break;
                POLineItemLoop850 loop = GetLoopValue<POLineItemLoop850>(args.Element);
                if (transaction.POLineItemLoopForDeserialize == null)
                    transaction.POLineItemLoopForDeserialize = new List<POLineItemLoop850>();
                transaction.POLineItemLoopForDeserialize.Add(loop);
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
