using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange810;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "810")]
public static class X12Steps810
{
    public static Interchange Deserialize810EDI(string document810, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document810, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document810);
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

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "810")
                    throw new InvalidOperationException("Incorrect document being used. Please use 810");

                Transaction810? tx = result?.FunctionGroup?.Transaction;
                if (tx?.NameAddressLoopForDeserialize != null)
                {
                    tx.NameAddressLoop = tx.NameAddressLoopForDeserialize.ToArray();
                    tx.NameAddressLoopForDeserialize = null;
                }
                if (tx?.InvoiceLineItemLoopForDeserialize != null)
                {
                    tx.InvoiceLineItemLoop = tx.InvoiceLineItemLoopForDeserialize.ToArray();
                    tx.InvoiceLineItemLoopForDeserialize = null;
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
            case "N1": // NameAddressLoop810
            {
                Transaction810? transaction = args?.ObjectBeingDeserialized as Transaction810;
                if (transaction == null)
                    break;
                NameAddressLoop810 loop = GetLoopValue<NameAddressLoop810>(args.Element);
                if (transaction.NameAddressLoopForDeserialize == null)
                    transaction.NameAddressLoopForDeserialize = new List<NameAddressLoop810>();
                transaction.NameAddressLoopForDeserialize.Add(loop);
            }
                break;
            case "IT1": // InvoiceLineItemLoop810
            {
                Transaction810? transaction = args?.ObjectBeingDeserialized as Transaction810;
                if (transaction == null)
                    break;
                InvoiceLineItemLoop810 loop = GetLoopValue<InvoiceLineItemLoop810>(args.Element);
                if (transaction.InvoiceLineItemLoopForDeserialize == null)
                    transaction.InvoiceLineItemLoopForDeserialize = new List<InvoiceLineItemLoop810>();
                transaction.InvoiceLineItemLoopForDeserialize.Add(loop);
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
