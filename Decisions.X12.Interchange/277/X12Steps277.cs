using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Utilities;

namespace X12Interchange277;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "277")]
public class X12Steps277
{
    public static Interchange Deseriale277X364(string ediString, bool inputIsPath = false)
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
                        OnUnknownElement = HandleUnknownElement
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "277")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 277");
                

                if (result?.FunctionGroup?.Transaction?.SourceLevelLoopForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.SourceLevelLoop =
                        result.FunctionGroup.Transaction.SourceLevelLoopForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.SourceLevelLoopForDeserialize = null;
                }

                if (result?.FunctionGroup?.Transaction?.SourceLevelLoop.Length > 0)
                {
                    if (result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                            .ProviderLevelLoop364ForDeserialize != null)
                    {
                        result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364.ProviderLevelLoop364 =
                            result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                                .ProviderLevelLoop364ForDeserialize.ToArray();
                        result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                            .ProviderLevelLoop364ForDeserialize = null;
                    }
                }
                
                if (result?.FunctionGroup?.Transaction?.SourceLevelLoop.Length > 0)
                {
                    if (result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                            .ProviderLevelLoop364.Length > 0)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                                     .ProviderLevelLoop364)
                        {
                            if (t.PatientLevelLoop364ForDeserialize != null)
                            {
                                t.PatientLevelLoop364 = t
                                    .PatientLevelLoop364ForDeserialize.ToArray();
                                t
                                    .PatientLevelLoop364ForDeserialize = null;
                            }
                        }
                    }
                }
                
                if (result?.FunctionGroup?.Transaction?.SourceLevelLoop.Length > 0)
                {
                    if (result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                            .ProviderLevelLoop364.Length > 0)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.SourceLevelLoop[0].ReceiverLevelLoop364
                                     .ProviderLevelLoop364)
                        {
                            for (int i = 0; i < t.PatientLevelLoop364.Length; i++)
                            {
                                if (t.PatientLevelLoop364[i]
                                        .ClaimLevelStatusInformationLoop364ForDeserialize != null)
                                {
                                    t.PatientLevelLoop364[i].ClaimLevelTrackingNumberLoop = t.PatientLevelLoop364[i]
                                        .ClaimLevelStatusInformationLoop364ForDeserialize.ToArray();
                                    t.PatientLevelLoop364[i].ClaimLevelStatusInformationLoop364ForDeserialize = null;
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
                case "2000A": // HierarchicalLoop
                {
                    Transaction364 transaction = args?.ObjectBeingDeserialized as Transaction364;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 2000A to be SourceLevelLoopLoop inside Transaction");
                    
                    SourceLevelLoop364 loop364 = GetLoopValue<SourceLevelLoop364>(args.Element);
                    if (transaction.SourceLevelLoopForDeserialize == null)
                        transaction.SourceLevelLoopForDeserialize = new List<SourceLevelLoop364>();

                    transaction.SourceLevelLoopForDeserialize.Add(loop364);
                }
                break;
                case "2100A": // PayerNameLoop
                {
                    SourceLevelLoop364 sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop364;

                    if (sourceLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2100A inside SourceLevelLoop");

                    PayerNameLoop364 loop364 = GetLoopValue<PayerNameLoop364>(args.Element);

                    sourceLevelLoop.PayerNameLoop364 = loop364;
                } 
                break;
                case "2200A": // ClaimSubmitterTraceNumberLoop
                {
                    SourceLevelLoop364 sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop364;

                    if (sourceLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2200A inside SourceLevelLoop");
                    
                    ClaimSubmitterTraceNumberLoop364 loop364 =
                        GetLoopValue<ClaimSubmitterTraceNumberLoop364>(args.Element);

                    sourceLevelLoop.ClaimSubmitterTraceNumberLoop364 = loop364;
                }
                break;
                case "2000B": // ReceiverLevelLoop
                {
                    SourceLevelLoop364 sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop364;

                    if (sourceLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2000B inside SourceLevelLoop");
                    
                    ReceiverLevelLoop364 loop364 =
                        GetLoopValue<ReceiverLevelLoop364>(args.Element);

                    sourceLevelLoop.ReceiverLevelLoop364 = loop364;
                }
                break;
                case "2100B": // ReceiverNameLoop
                {
                    ReceiverLevelLoop364 receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop364;

                    if (receiverLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2100B inside ReceiverLevelLoop");
                    
                    PayerNameLoop364 loop364 =
                        GetLoopValue<PayerNameLoop364>(args.Element);

                    receiverLevelLoop.ReceiverNameLoop364 = loop364;
                }
                break;
                case "2200B": // ReceiverTraceLoop
                {
                    ReceiverLevelLoop364 receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop364;

                    if (receiverLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2200B inside ReceiverLevelLoop");
                    
                    ReceiverTraceLoop364 loop364 =
                        GetLoopValue<ReceiverTraceLoop364>(args.Element);

                    receiverLevelLoop.ReceiverTraceLoop364 = loop364;
                }
                break;
                case "2000C": //ServiceProviderLevelLoop
                {
                    ReceiverLevelLoop364 receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop364;

                    if (receiverLevelLoop == null)
                        throw new InvalidOperationException("Expected LoopId 2000C inside ReceiverLevelLoop");
                    
                    ProviderLevelLoop364 loop364 =
                        GetLoopValue<ProviderLevelLoop364>(args.Element);

                    if (receiverLevelLoop.ProviderLevelLoop364ForDeserialize == null)
                        receiverLevelLoop.ProviderLevelLoop364ForDeserialize = new List<ProviderLevelLoop364>();

                    receiverLevelLoop.ProviderLevelLoop364ForDeserialize.Add(loop364);
                }
                break;
                case "2100C":
                {
                    ProviderLevelLoop364 providerLevelLoop364 = args?.ObjectBeingDeserialized as ProviderLevelLoop364;

                    if (providerLevelLoop364 == null)
                        throw new InvalidOperationException("Expected LoopId 2100C inside ProviderLevelLoop");
                    
                    PayerNameLoop364 providerNameLoop = GetLoopValue<PayerNameLoop364>(args.Element);

                    providerLevelLoop364.ProviderNameLoop = providerNameLoop;
                }
                break;
                case "2200C":
                {
                    ProviderLevelLoop364 providerLevelLoop364 = args?.ObjectBeingDeserialized as ProviderLevelLoop364;

                    if (providerLevelLoop364 == null)
                        throw new InvalidOperationException("Expected LoopId 2200C inside ProviderLevelLoop");

                    ProviderTraceLoop364 loop364 = GetLoopValue<ProviderTraceLoop364>(args.Element);

                    providerLevelLoop364.ProviderTraceLoop364 = loop364;
                }
                break;
                case "2000D":
                {
                    ProviderLevelLoop364 providerLevelLoop364 = args?.ObjectBeingDeserialized as ProviderLevelLoop364;
                    if (providerLevelLoop364 == null)
                        throw new InvalidOperationException("Expected LoopId 2000D inside ProviderLevelLoop");

                    PatientLevelLoop364 loop364 = GetLoopValue<PatientLevelLoop364>(args.Element);

                    if (providerLevelLoop364.PatientLevelLoop364ForDeserialize == null)
                        providerLevelLoop364.PatientLevelLoop364ForDeserialize = new List<PatientLevelLoop364>();
                    
                    providerLevelLoop364.PatientLevelLoop364ForDeserialize.Add(loop364);
                }
                break;
                case "2100D":
                {
                    PatientLevelLoop364 patientLevelLoop364 = args?.ObjectBeingDeserialized as PatientLevelLoop364;

                    if (patientLevelLoop364 == null)
                        throw new InvalidOperationException("Expected LoopId 2100D inside PatientLevelLoop");
                    PayerNameLoop364 loop364 = GetLoopValue<PayerNameLoop364>(args.Element);

                    patientLevelLoop364.PatientNameLoop = loop364;
                }
                break;
                case "2200D":
                {
                    PatientLevelLoop364 patientLevelLoop364 = args?.ObjectBeingDeserialized as PatientLevelLoop364;
                    if (patientLevelLoop364 == null)
                        throw new InvalidOperationException("Expected LoopId 2200D inside PatientLevelLoop");

                    ClaimLevelTrackingNumberLoop364 loop364 = GetLoopValue<ClaimLevelTrackingNumberLoop364>(args.Element);

                    if (patientLevelLoop364.ClaimLevelStatusInformationLoop364ForDeserialize == null)
                        patientLevelLoop364.ClaimLevelStatusInformationLoop364ForDeserialize = new List<ClaimLevelTrackingNumberLoop364>();
                    
                    patientLevelLoop364.ClaimLevelStatusInformationLoop364ForDeserialize.Add(loop364);
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