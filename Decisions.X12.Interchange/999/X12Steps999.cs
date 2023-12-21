using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange999;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "999")]
public class X12Steps999
{
    public static Interchange Deserialize999(string Document999, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string -> Interchange
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document999, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document999);
                }

                fs.Position = 0;
            }

            interchange = parser.Parse(fs);
        }

        // Create a temporary file with no sharing permissions that will be deleted when closed:
        using (FileStream fs = new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite,
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

            using (XmlReader xmlReader = XmlReader.Create(fs,
                       new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
            {
                Interchange result = (Interchange)serializer.Deserialize(xmlReader,
                    new XmlDeserializationEvents
                    {
                        OnUnknownElement = HandleUnknownElement
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "999")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 999");

                if (result?.FunctionGroup?.Transaction?.TransactionSetResponseHeaderLoop2000ForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000 = result.FunctionGroup
                        .Transaction.TransactionSetResponseHeaderLoop2000ForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000ForDeserialize = null;

                    if (result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000 != null)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000)
                        {
                            if (t.ErrorIdentificationLoop2100ForDeserialize != null)
                            {
                                t.ErrorIdentificationLoop2100 = t.ErrorIdentificationLoop2100ForDeserialize.ToArray();
                                t.ErrorIdentificationLoop2100ForDeserialize = null;

                                if (t.ErrorIdentificationLoop2100 != null)
                                {
                                    foreach (var s in t.ErrorIdentificationLoop2100)
                                    {
                                        if (s.ImplementationDataElementNoteLoop2110ForDeserialize != null)
                                        {
                                            s.ImplementationDataElementNoteLoop2110 =
                                                s.ImplementationDataElementNoteLoop2110ForDeserialize.ToArray();
                                            s.ImplementationDataElementNoteLoop2110ForDeserialize = null;
                                        }
                                    }
                                }
                            }
                        }
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
                Transaction999 transaction = args?.ObjectBeingDeserialized as Transaction999;
                if(transaction == null)
                    throw new InvalidOperationException("Expected LoopId 2000 to be TransactionSetResponseHeaderLoop inside Transaction");

                TransactionSetResponseHeaderLoop2000 loop =
                    GetLoopValue<TransactionSetResponseHeaderLoop2000>(args.Element);

                if (transaction.TransactionSetResponseHeaderLoop2000ForDeserialize == null)
                    transaction.TransactionSetResponseHeaderLoop2000ForDeserialize =
                        new List<TransactionSetResponseHeaderLoop2000>();
                
                transaction.TransactionSetResponseHeaderLoop2000ForDeserialize.Add(loop);
            }
            break;
            case "2100": // ErrorIdentificationLoop
            {
                TransactionSetResponseHeaderLoop2000 headerLoop2000 = args?.ObjectBeingDeserialized as TransactionSetResponseHeaderLoop2000;
                if(headerLoop2000 == null)
                    throw new InvalidOperationException("Expected LoopId 2100 to be ErrorIdentificationLoop inside TransactionSetResponseHeaderLoop");

                ErrorIdentificationLoop2100 loop =
                    GetLoopValue<ErrorIdentificationLoop2100>(args.Element);

                if (headerLoop2000.ErrorIdentificationLoop2100ForDeserialize == null)
                    headerLoop2000.ErrorIdentificationLoop2100ForDeserialize =
                        new List<ErrorIdentificationLoop2100>();
                
                headerLoop2000.ErrorIdentificationLoop2100ForDeserialize.Add(loop);
            }
            break;
            case "2110": // ImplementationDataElementNoteLoop
            {
                ErrorIdentificationLoop2100 identificationLoop2000 = args?.ObjectBeingDeserialized as ErrorIdentificationLoop2100;
                if(identificationLoop2000 == null)
                    throw new InvalidOperationException("Expected LoopId 2110 to be ImplementationDataElementNoteLoop inside ErrorIdentificationLoop");

                ImplementationDataElementNoteLoop2110 loop =
                    GetLoopValue<ImplementationDataElementNoteLoop2110>(args.Element);

                if (identificationLoop2000.ImplementationDataElementNoteLoop2110ForDeserialize == null)
                    identificationLoop2000.ImplementationDataElementNoteLoop2110ForDeserialize =
                        new List<ImplementationDataElementNoteLoop2110>();
                
                identificationLoop2000.ImplementationDataElementNoteLoop2110ForDeserialize.Add(loop);
            }
            break;
        }
    }
    
    private static TLoop GetLoopValue<TLoop>(XmlElement element)
    {
        using (StringReader stringReader = new StringReader(element.OuterXml))
        using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
        {
            XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
            TLoop loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
            {
                OnUnknownElement = HandleUnknownElement
            });

            return loop;
        }
    }
}