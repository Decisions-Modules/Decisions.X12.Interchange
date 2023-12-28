using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange835;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "835")]
public class X12Steps835
{
    public static Interchange Deserialize835EDI(string Document835, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document835, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document835);
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

                if (result?.FunctionGroup?.Transaction?.ST.ST01 != "835")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 835");

                if (result?.FunctionGroup?.Transaction?.HeaderNumberLoopForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.HeaderNumberLoop = result.FunctionGroup.Transaction
                        .HeaderNumberLoopForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.HeaderNumberLoopForDeserialize = null;
                    
                    foreach (var t in result.FunctionGroup.Transaction.HeaderNumberLoop)
                    {
                        if (t.ClaimPaymentInformationLoopForDeserialize != null)
                        {
                            t.ClaimPaymentInformationLoop = t.ClaimPaymentInformationLoopForDeserialize.ToArray();
                            t.ClaimPaymentInformationLoopForDeserialize = null;
                            
                            if (t.ClaimPaymentInformationLoop != null)
                            {
                                foreach (var s in t.ClaimPaymentInformationLoop)
                                {
                                    if (s.ServicePaymentInformationLoopForDeserialize != null)
                                    {
                                        s.ServicePaymentInformationLoop = s.ServicePaymentInformationLoopForDeserialize.ToArray();
                                        s.ServicePaymentInformationLoopForDeserialize = null;
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
                case "1000A": // PayerIdentificationLoop
                {
                    Transaction835 transaction = args?.ObjectBeingDeserialized as Transaction835;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000A to be PayerIdentificationLoop inside Transaction");
                    
                    PayerIdentificationLoop loop = GetLoopValue<PayerIdentificationLoop>(args.Element);

                    transaction.PayerIdentificationLoop = loop;
                } 
                break;
                case "1000B": // PayeeIdentificationLoop
                {
                    Transaction835 transaction = args?.ObjectBeingDeserialized as Transaction835;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000B to be PayeeIdentificationLoop inside Transaction");
                    
                    PayeeIdentificationLoop loop = GetLoopValue<PayeeIdentificationLoop>(args.Element);

                    transaction.PayeeIdentificationLoop = loop;
                } 
                break;
                case "2000": // HeaderNumberLoop
                {
                    Transaction835 transaction = args?.ObjectBeingDeserialized as Transaction835;
                    if (transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000 to be HeaderNumberLoop inside Transaction");
                    HeaderNumberLoop loop = GetLoopValue<HeaderNumberLoop>(args.Element);

                    if (transaction.HeaderNumberLoopForDeserialize == null)
                        transaction.HeaderNumberLoopForDeserialize = new List<HeaderNumberLoop>();
                    
                    transaction.HeaderNumberLoopForDeserialize.Add(loop);
                }
                break;
                case "2100": // ClaimPaymentInformationLoop
                {
                    HeaderNumberLoop headerNumber = args?.ObjectBeingDeserialized as HeaderNumberLoop;
                    if (headerNumber == null)
                        throw new InvalidOperationException("Expected LoopId 2100 to be ClaimPaymentInformationLoop inside HeaderNumberLoop");
                    
                    ClaimPaymentInformationLoop loop = GetLoopValue<ClaimPaymentInformationLoop>(args.Element);

                    if (headerNumber.ClaimPaymentInformationLoopForDeserialize == null)
                        headerNumber.ClaimPaymentInformationLoopForDeserialize = new List<ClaimPaymentInformationLoop>();
                    
                    headerNumber.ClaimPaymentInformationLoopForDeserialize.Add(loop);
                }
                break;
                case "2110": // ServicePaymentInformationLoop
                {
                    ClaimPaymentInformationLoop claimPaymentInformationLoop = args?.ObjectBeingDeserialized as ClaimPaymentInformationLoop;
                    if(claimPaymentInformationLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2110 to be ServicePaymentInformationLoop inside ClaimPaymentInformationLoop");

                    ServicePaymentInformationLoop loop = GetLoopValue<ServicePaymentInformationLoop>(args.Element);

                    if (claimPaymentInformationLoop.ServicePaymentInformationLoopForDeserialize == null)
                        claimPaymentInformationLoop.ServicePaymentInformationLoopForDeserialize =
                            new List<ServicePaymentInformationLoop>();
                    
                    claimPaymentInformationLoop.ServicePaymentInformationLoopForDeserialize.Add(loop);
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