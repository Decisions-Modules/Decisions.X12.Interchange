using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange824;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "824")]
public class X12Steps824 
{
     public static Interchange Deserialize824(string Document824, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document824, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document824);
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

                    if (result.FunctionGroup.Transaction.OTILoop != null)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.OTILoop)
                        {
                            if (t.TEDLoopForDeserialize != null)
                            {
                                t.TEDLoop = t.TEDLoopForDeserialize.ToArray();
                                t.TEDLoopForDeserialize = null;
                            }

                            if (t.LMLoopForDeserialize != null)
                            {
                                t.LMLoop = t.LMLoopForDeserialize.ToArray();
                                t.LMLoopForDeserialize = null;

                                if (t.LMLoop != null)
                                {
                                    foreach (var s in t.LMLoop)
                                    {
                                        if (s.LQLoopForDeserialize != null)
                                        {
                                            s.LQLoop = s.LQLoopForDeserialize.ToArray();
                                            s.LQLoopForDeserialize = null;
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
            if (args?.Element?.Name != "Loop")
                return;
            
            switch (args?.Element?.Attributes?["LoopId"]?.Value)
            {
                case "N1": // N1Loop
                {
                    Transaction824 transaction = args?.ObjectBeingDeserialized as Transaction824;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId N1 to be N1Loop inside Transaction");
                    
                    N1Loop n1Loop = GetLoopValue<N1Loop>(args.Element);
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
                    
                    OTILoop otiLoop = GetLoopValue<OTILoop>(args.Element);
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

                    TEDLoop tedLoop = GetLoopValue<TEDLoop>(args.Element);
                    
                    if (otiLoop.TEDLoopForDeserialize == null)
                        otiLoop.TEDLoopForDeserialize = new List<TEDLoop>();
                    
                    otiLoop.TEDLoopForDeserialize.Add(tedLoop);
                }
                break;
                case "LM": // LMLoop
                {
                    OTILoop otiLoop = args?.ObjectBeingDeserialized as OTILoop;
                    if (otiLoop == null)
                        throw new InvalidOperationException("Expected LoopId LM to be LMLoop inside OTILoop");

                    LMLoop lmLoop = GetLoopValue<LMLoop>(args.Element);
                    
                    if (otiLoop.LMLoopForDeserialize == null)
                        otiLoop.LMLoopForDeserialize = new List<LMLoop>();
                    
                    otiLoop.LMLoopForDeserialize.Add(lmLoop);
                }
                break;
                case "LQ": // LQLoop
                {
                    LMLoop lmLoop = args?.ObjectBeingDeserialized as LMLoop;
                    if (lmLoop == null)
                        throw new InvalidOperationException("Expected LoopId LQ to be LQLoop inside LMLoop");

                    LQLoop lqLoop = GetLoopValue<LQLoop>(args.Element);

                    if (lmLoop.LQLoopForDeserialize == null)
                        lmLoop.LQLoopForDeserialize = new List<LQLoop>();
                    
                    lmLoop.LQLoopForDeserialize.Add(lqLoop);
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