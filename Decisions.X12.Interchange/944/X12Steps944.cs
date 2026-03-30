using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange944;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "944")]
public static class X12Steps944
{
    public static Interchange Deserialize944EDI(string document944, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string.
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(document944, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(document944);
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

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "944")
                    throw new InvalidOperationException("Incorrect document being used. Please use 944");

                Transaction944? tx = result?.FunctionGroup?.Transaction;
                if (tx?.NameAddressLoopForDeserialize != null)
                {
                    tx.NameAddressLoop = tx.NameAddressLoopForDeserialize.ToArray();
                    tx.NameAddressLoopForDeserialize = null;
                }
                if (tx?.ItemDetailReceiptLoopForDeserialize != null)
                {
                    tx.ItemDetailReceiptLoop = tx.ItemDetailReceiptLoopForDeserialize.ToArray();
                    tx.ItemDetailReceiptLoopForDeserialize = null;

                    foreach (ItemDetailReceiptLoop944 item in tx.ItemDetailReceiptLoop)
                        if (item.ItemDetailExceptionLoopForDeserialize != null)
                        {
                            item.ItemDetailExceptionLoop = item.ItemDetailExceptionLoopForDeserialize.ToArray();
                            item.ItemDetailExceptionLoopForDeserialize = null;
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
            case "0100": // NameAddressLoop944
            {
                Transaction944? transaction = args?.ObjectBeingDeserialized as Transaction944;
                if (transaction == null)
                    break;
                NameAddressLoop944 loop = GetLoopValue<NameAddressLoop944>(args.Element);
                if (transaction.NameAddressLoopForDeserialize == null)
                    transaction.NameAddressLoopForDeserialize = new List<NameAddressLoop944>();
                transaction.NameAddressLoopForDeserialize.Add(loop);
            }
                break;
            case "0200": // ItemDetailReceiptLoop944
            {
                Transaction944? transaction = args?.ObjectBeingDeserialized as Transaction944;
                if (transaction == null)
                    break;
                ItemDetailReceiptLoop944 loop = GetLoopValue<ItemDetailReceiptLoop944>(args.Element);
                if (transaction.ItemDetailReceiptLoopForDeserialize == null)
                    transaction.ItemDetailReceiptLoopForDeserialize = new List<ItemDetailReceiptLoop944>();
                transaction.ItemDetailReceiptLoopForDeserialize.Add(loop);
            }
                break;
            case "0210": // ItemDetailExceptionLoop944
            {
                ItemDetailReceiptLoop944? itemDetail = args?.ObjectBeingDeserialized as ItemDetailReceiptLoop944;
                if (itemDetail == null)
                    break;
                ItemDetailExceptionLoop944 loop = GetLoopValue<ItemDetailExceptionLoop944>(args.Element);
                if (itemDetail.ItemDetailExceptionLoopForDeserialize == null)
                    itemDetail.ItemDetailExceptionLoopForDeserialize = new List<ItemDetailExceptionLoop944>();
                itemDetail.ItemDetailExceptionLoopForDeserialize.Add(loop);
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
