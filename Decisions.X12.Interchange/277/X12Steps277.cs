using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using X12Interchange277X364;
using Interchange = X12Interchange277X364.Interchange;

namespace X12Interchange277;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "277")]
public class X12Steps277
{
    public static Interchange Deserialize277X364(string Document277, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document277, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document277);
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
                        OnUnknownElement = HandleUnknownElement364
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "277")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 277");


                if (result?.FunctionGroup?.Transaction?.SourceLevelLoop3642000AForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.SourceLevelLoop3642000A =
                        result.FunctionGroup.Transaction.SourceLevelLoop3642000AForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.SourceLevelLoop3642000AForDeserialize = null;

                    if (result.FunctionGroup.Transaction.SourceLevelLoop3642000A != null)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.SourceLevelLoop3642000A)
                        {
                            if (t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000CForDeserialize != null)
                            {
                                t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000C =
                                    t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000CForDeserialize.ToArray();
                                t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000CForDeserialize = null;
                            }

                            if (t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000C != null)
                            {
                                foreach (var s in t.ReceiverLevelLoop3642000B.ProviderLevelLoop3642000C)
                                {
                                    if (s.PatientLevelLoop3642000DForDeserialize != null)
                                    {
                                        s.PatientLevelLoop3642000D = s.PatientLevelLoop3642000DForDeserialize.ToArray();
                                        s.PatientLevelLoop3642000DForDeserialize = null;
                                    }

                                    if (s.PatientLevelLoop3642000D != null)
                                    {
                                        foreach (var r in s.PatientLevelLoop3642000D)
                                        {
                                            if (r.ClaimStatusTrackingNumberLoop3642200DForDeserialize != null)
                                            {
                                                r.ClaimStatusTrackingNumberLoop3642200D =
                                                    r.ClaimStatusTrackingNumberLoop3642200DForDeserialize.ToArray();
                                                r.ClaimStatusTrackingNumberLoop3642200DForDeserialize = null;
                                            }

                                            if (r.ClaimStatusTrackingNumberLoop3642200D != null)
                                            {
                                                foreach (var q in r.ClaimStatusTrackingNumberLoop3642200D)
                                                {
                                                    if (q.ServiceLineLoop3642220DForDeserialize != null)
                                                    {
                                                        q.ServiceLineLoop3642220D =
                                                            q.ServiceLineLoop3642220DForDeserialize.ToArray();
                                                        q.ServiceLineLoop3642220DForDeserialize = null;
                                                    }
                                                }
                                            }
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

    private static void HandleUnknownElement364(object obj, XmlElementEventArgs args)
    {
        if ((bool)!args?.Element?.Name?.Contains("Loop"))
            return;
        
        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "2000A": // HierarchicalLoop
            {
                Transaction364 transaction = args?.ObjectBeingDeserialized as Transaction364;
                if(transaction == null)
                    throw new InvalidOperationException("Expected LoopId 2000A to be SourceLevelLoop inside Transaction");
                
                SourceLevelLoop3642000A loop3642000A = GetLoopValue364<SourceLevelLoop3642000A>(args.Element);
                if (transaction.SourceLevelLoop3642000AForDeserialize == null)
                    transaction.SourceLevelLoop3642000AForDeserialize = new List<SourceLevelLoop3642000A>();

                transaction.SourceLevelLoop3642000AForDeserialize.Add(loop3642000A);
            }
            break;
            case "2100A": // PayerNameLoop
            {
                SourceLevelLoop3642000A sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop3642000A;

                if (sourceLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2100A to be PayerNameLoop inside SourceLevelLoop");

                PayerNameLoop3642100A loop3642100A = GetLoopValue364<PayerNameLoop3642100A>(args.Element);

                sourceLevelLoop.PayerNameLoop3642100A = loop3642100A;
            } 
            break;
            case "2200A": // ClaimSubmitterTraceNumberLoop
            {
                SourceLevelLoop3642000A sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop3642000A;

                if (sourceLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2200A to be ClaimSubmitterTraceNumberLoop inside SourceLevelLoop");
                
                ClaimSubmitterTraceNumberLoop3642200A loop3642200A =
                    GetLoopValue364<ClaimSubmitterTraceNumberLoop3642200A>(args.Element);

                sourceLevelLoop.ClaimSubmitterTraceNumberLoop3642200A = loop3642200A;
            }
            break;
            case "2000B": // ReceiverLevelLoop
            {
                SourceLevelLoop3642000A sourceLevelLoop = args?.ObjectBeingDeserialized as SourceLevelLoop3642000A;

                if (sourceLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2000B to be ReceiverLevelLoop inside SourceLevelLoop");
                
                ReceiverLevelLoop3642000B loop3642000B =
                    GetLoopValue364<ReceiverLevelLoop3642000B>(args.Element);

                sourceLevelLoop.ReceiverLevelLoop3642000B = loop3642000B;
            }
            break;
            case "2100B": // ReceiverNameLoop
            {
                ReceiverLevelLoop3642000B receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop3642000B;

                if (receiverLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2100B to be ReceiverNameLoop inside ReceiverLevelLoop");
                
                ReceiverNameLoop3642100B loop3642100B =
                    GetLoopValue364<ReceiverNameLoop3642100B>(args.Element);

                receiverLevelLoop.ReceiverNameLoop3642100B = loop3642100B;
            }
            break;
            case "2200B": // ReceiverTraceLoop
            {
                ReceiverLevelLoop3642000B receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop3642000B;

                if (receiverLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2200B to be ReceiverTraceLoop inside ReceiverLevelLoop");
                
                ReceiverTraceLoop3642200B loop3642200B =
                    GetLoopValue364<ReceiverTraceLoop3642200B>(args.Element);

                receiverLevelLoop.ReceiverTraceLoop3642200B = loop3642200B;
            }
            break;
            case "2000C": // ProviderLevelLoop
            {
                ReceiverLevelLoop3642000B receiverLevelLoop = args?.ObjectBeingDeserialized as ReceiverLevelLoop3642000B;

                if (receiverLevelLoop == null)
                    throw new InvalidOperationException("Expected LoopId 2000C to be ServiceProviderLevelLoop inside ReceiverLevelLoop");
                
                ProviderLevelLoop3642000C loop3642000C =
                    GetLoopValue364<ProviderLevelLoop3642000C>(args.Element);

                if (receiverLevelLoop.ProviderLevelLoop3642000CForDeserialize == null)
                    receiverLevelLoop.ProviderLevelLoop3642000CForDeserialize = new List<ProviderLevelLoop3642000C>();

                receiverLevelLoop.ProviderLevelLoop3642000CForDeserialize.Add(loop3642000C);
            }
            break;
            case "2100C": // ProviderNameLoop
            {
                ProviderLevelLoop3642000C providerLevelLoop3642000C = args?.ObjectBeingDeserialized as ProviderLevelLoop3642000C;

                if (providerLevelLoop3642000C == null)
                    throw new InvalidOperationException("Expected LoopId 2100C to be ProviderNameLoop inside ProviderLevelLoop");
                
                ProviderNameLoop3642100C providerNameLoop = GetLoopValue364<ProviderNameLoop3642100C>(args.Element);

                providerLevelLoop3642000C.ProviderNameLoop3642100C = providerNameLoop;
            }
            break;
            case "2200C": // ProviderTraceLoop
            {
                ProviderLevelLoop3642000C providerLevelLoop3642000C = args?.ObjectBeingDeserialized as ProviderLevelLoop3642000C;

                if (providerLevelLoop3642000C == null)
                    throw new InvalidOperationException("Expected LoopId 2200C to be ProviderTraceLoop inside ProviderLevelLoop");

                ProviderTraceLoop3642200C loop3642200C = GetLoopValue364<ProviderTraceLoop3642200C>(args.Element);

                providerLevelLoop3642000C.ProviderTraceLoop3642200C = loop3642200C;
            }
            break;
            case "2000D": // PatientLevelLoop
            {
                ProviderLevelLoop3642000C providerLevelLoop3642000C = args?.ObjectBeingDeserialized as ProviderLevelLoop3642000C;
                if (providerLevelLoop3642000C == null)
                    throw new InvalidOperationException("Expected LoopId 2000D to be PatientLevelLoop inside ProviderLevelLoop");

                PatientLevelLoop3642000D loop3642000D = GetLoopValue364<PatientLevelLoop3642000D>(args.Element);

                if (providerLevelLoop3642000C.PatientLevelLoop3642000DForDeserialize == null)
                    providerLevelLoop3642000C.PatientLevelLoop3642000DForDeserialize = new List<PatientLevelLoop3642000D>();
                
                providerLevelLoop3642000C.PatientLevelLoop3642000DForDeserialize.Add(loop3642000D);
            }
            break;
            case "2100D": // PatientNameLoop
            {
                PatientLevelLoop3642000D patientLevelLoop3642000D = args?.ObjectBeingDeserialized as PatientLevelLoop3642000D;

                if (patientLevelLoop3642000D == null)
                    throw new InvalidOperationException("Expected LoopId 2100D to be PatientNameLoop inside PatientLevelLoop");
                
                PatientNameLoop3642100D loop3642100A = GetLoopValue364<PatientNameLoop3642100D>(args.Element);

                patientLevelLoop3642000D.PatientNameLoop3642100D = loop3642100A;
            }
            break;
            case "2200D": // ClaimStatusTrackingNumberLoop
            {
                PatientLevelLoop3642000D patientLevelLoop3642000D = args?.ObjectBeingDeserialized as PatientLevelLoop3642000D;
                if (patientLevelLoop3642000D == null)
                    throw new InvalidOperationException("Expected LoopId 2200D to be ClaimStatusTrackingNumberLoop inside PatientLevelLoop");

                ClaimStatusTrackingNumberLoop3642200D loop3642200D = GetLoopValue364<ClaimStatusTrackingNumberLoop3642200D>(args.Element);

                if (patientLevelLoop3642000D.ClaimStatusTrackingNumberLoop3642200DForDeserialize == null)
                    patientLevelLoop3642000D.ClaimStatusTrackingNumberLoop3642200DForDeserialize = new List<ClaimStatusTrackingNumberLoop3642200D>();
                
                patientLevelLoop3642000D.ClaimStatusTrackingNumberLoop3642200DForDeserialize.Add(loop3642200D);
            }
            break;
            case "2220D": // ServiceLineLoop
            {
                ClaimStatusTrackingNumberLoop3642200D claimStatusTrackingNumberLoop3642200D = args?.ObjectBeingDeserialized as ClaimStatusTrackingNumberLoop3642200D;
                if (claimStatusTrackingNumberLoop3642200D == null)
                    throw new InvalidOperationException("Expected LoopId 2220D to be ServiceLineLoop inside ClaimStatusTrackingNumberLoop");

                ServiceLineLoop3642220D loop3642220D = GetLoopValue364<ServiceLineLoop3642220D>(args.Element);
                
                if (claimStatusTrackingNumberLoop3642200D.ServiceLineLoop3642220DForDeserialize == null)
                    claimStatusTrackingNumberLoop3642200D.ServiceLineLoop3642220DForDeserialize =
                        new List<ServiceLineLoop3642220D>();
                
                claimStatusTrackingNumberLoop3642200D.ServiceLineLoop3642220DForDeserialize.Add(loop3642220D);
            }
            break;
        }
    }
      
      private static TLoop GetLoopValue364<TLoop>(XmlElement element)
      {
          using (StringReader stringReader = new StringReader(element.OuterXml))
          using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
          {
              XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
              TLoop loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
              {
                  OnUnknownElement = HandleUnknownElement364
              });

              return loop;
          }
      }
}