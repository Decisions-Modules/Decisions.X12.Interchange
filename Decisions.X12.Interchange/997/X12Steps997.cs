using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange997;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "997")]
public class X12Steps997
{
    public static Interchange Deserialize997(string Document997, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string -> Interchange
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (var fs = inputIsPath
                   ? new FileStream(Document997, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document997);
                }

                fs.Position = 0;
            }

            interchange = parser.Parse(fs);
        }

        // Create a temporary file with no sharing permissions that will be deleted when closed:
        using (var fs = new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite,
                   FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            // Serialize the Interchange to file:
            interchange.Serialize(fs);
            // Prepare to read what we just wrote:
            fs.Position = 0;
            // Ignore ISA16 so the XmlSerializer doesn't throw an error when it sees an object instead of a string:
            var overrides = new XmlAttributeOverrides();
            overrides.Add(typeof(ISA), nameof(ISA.ISA16), new XmlAttributes { XmlIgnore = true });
            var serializer = new XmlSerializer(typeof(Interchange), overrides);

            using (var xmlReader = XmlReader.Create(fs,
                       new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
            {
                var result = (Interchange)serializer.Deserialize(xmlReader,
                    new XmlDeserializationEvents
                    {
                        OnUnknownElement = HandleUnknownElement
                    });

                if (result?.FunctionGroup.Transactions.Any(t => t.ST.ST01 != "997") ?? true)
                    throw new InvalidOperationException("Incorrect document being used.  Please use 997");

                if (result?.FunctionGroup?.Transaction?.TransactionSetResponseHeaderLoop2000ForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000 = result.FunctionGroup
                        .Transaction.TransactionSetResponseHeaderLoop2000ForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000ForDeserialize = null;

                    if (result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000 != null)
                        foreach (var t in result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000)
                            if (t.DataSegmentLoop2100ForDeserialize != null)
                            {
                                t.DataSegmentLoop2100 = t.DataSegmentLoop2100ForDeserialize.ToArray();
                                t.DataSegmentLoop2100ForDeserialize = null;
                            }
                }

                return result;
            }
        }
    }

    private static void HandleUnknownElement(object obj, XmlElementEventArgs args)
    {
        if ((bool)!args?.Element?.Name?.Contains("Loop"))
            return;

        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "2000": // TransactionSetResponseHeaderLoop
            {
                var transaction = args?.ObjectBeingDeserialized as Transaction997;
                if (transaction == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2000 to be TransactionSetResponseHeaderLoop inside Transaction");

                var loop =
                    GetLoopValue<TransactionSetResponseHeaderLoop2000>(args.Element);

                if (transaction.TransactionSetResponseHeaderLoop2000ForDeserialize == null)
                    transaction.TransactionSetResponseHeaderLoop2000ForDeserialize =
                        new List<TransactionSetResponseHeaderLoop2000>();

                transaction.TransactionSetResponseHeaderLoop2000ForDeserialize.Add(loop);
            }
                break;
            case "2100": // ErrorIdentificationLoop
            {
                var headerLoop2000 = args?.ObjectBeingDeserialized as TransactionSetResponseHeaderLoop2000;
                if (headerLoop2000 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2100 to be ErrorIdentificationLoop inside TransactionSetResponseHeaderLoop");

                var loop =
                    GetLoopValue<DataSegmentLoop2100>(args.Element);

                if (headerLoop2000.DataSegmentLoop2100ForDeserialize == null)
                    headerLoop2000.DataSegmentLoop2100ForDeserialize =
                        new List<DataSegmentLoop2100>();

                headerLoop2000.DataSegmentLoop2100ForDeserialize.Add(loop);
            }
                break;
        }
    }

    private static TLoop GetLoopValue<TLoop>(XmlElement element)
    {
        using (var stringReader = new StringReader(element.OuterXml))
        using (var xmlReader = XmlReader.Create(stringReader,
                   new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
        {
            var ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
            var loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
            {
                OnUnknownElement = HandleUnknownElement
            });

            return loop;
        }
    }
}