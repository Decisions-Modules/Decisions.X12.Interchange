using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using X12InterchangeCommon;

namespace X12Interchange824;

[AutoRegisterMethodsOnClass(true, "Data", "X12")]
public class X12Steps824 
{
     public static Interchange Deseriale824EDI(string ediString, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(ediString, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(ediString);
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
                        OnUnknownElement = HandleUnknownElement824
                    });

                if (result?.FunctionGroup?.Transaction?.ST.ST01 != "824")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 824");
                
                if (result?.FunctionGroup?.Transaction?.N1LoopForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.N1Loop = result.FunctionGroup.Transaction
                        .N1LoopForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.N1LoopForDeserialize = null;
                }

                if (result?.FunctionGroup?.Transaction?.OTILoopForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.OTILoop =
                        result.FunctionGroup.Transaction.OTILoopForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.OTILoopForDeserialize = null;
                }

                if (result?.FunctionGroup?.Transaction?.OTILoop != null)
                {
                    for (int i = 0; i < result.FunctionGroup.Transaction.OTILoop.Length; i++)
                    {
                        if (result.FunctionGroup.Transaction.OTILoop[i].TEDLoopForDeserialize != null)
                        {
                            result.FunctionGroup.Transaction.OTILoop[i].TEDLoop = result.FunctionGroup.Transaction
                                .OTILoop[i].TEDLoopForDeserialize.ToArray();
                            result.FunctionGroup.Transaction.OTILoop[i].TEDLoopForDeserialize = null;
                        }
                    }
                }
                
                return result;
            }
        }
    }
     
      private static void HandleUnknownElement824(object obj, XmlElementEventArgs args)
        {
            if (args?.Element?.Name != "Loop")
                return;
            
            switch (args?.Element?.Attributes?["LoopId"]?.Value)
            {
                case "N1": // N1Loop
                {
                    Transaction824 transaction = args?.ObjectBeingDeserialized as Transaction824;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId N1 to be N1Loop inside Transaction");
                    
                    N1Loop n1Loop = GetLoopValue824<N1Loop>(args.Element);
                    if (transaction.N1LoopForDeserialize == null)
                        transaction.N1LoopForDeserialize = new List<N1Loop>();

                    transaction.N1LoopForDeserialize.Add(n1Loop);
                } 
                break;

                case "OTI": // OTILoop
                {
                    Transaction824 transaction = args?.ObjectBeingDeserialized as Transaction824;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId OTI to be OTILoop inside Transaction");
                    
                    OTILoop otiLoop = GetLoopValue824<OTILoop>(args.Element);
                    if (transaction.OTILoopForDeserialize == null)
                        transaction.OTILoopForDeserialize = new List<OTILoop>();

                    transaction.OTILoopForDeserialize.Add(otiLoop);
                } 
                break;

                case "TED": // TEDLoop
                {
                    OTILoop otiLoop = args?.ObjectBeingDeserialized as OTILoop;
                    if (otiLoop == null)
                        throw new InvalidOperationException("Expected LoopId TED to be TEDLoop inside OTILoop");

                    TEDLoop tedLoop = GetLoopValue824<TEDLoop>(args.Element);
                    
                    if (otiLoop.TEDLoopForDeserialize == null)
                        otiLoop.TEDLoopForDeserialize = new List<TEDLoop>();
                    
                    otiLoop.TEDLoopForDeserialize.Add(tedLoop);
                    
                }
                break;
            }
        }
      
      private static TLoop GetLoopValue824<TLoop>(XmlElement element)
      {
          using (StringReader stringReader = new StringReader(element.OuterXml))
          using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
          {
              XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
              TLoop loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
              {
                  OnUnknownElement = HandleUnknownElement824
              });

              return loop;
          }
      }
}