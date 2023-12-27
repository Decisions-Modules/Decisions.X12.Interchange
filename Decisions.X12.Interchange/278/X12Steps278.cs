using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Interchange278X217Review;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using Interchange = Decisions.X12.Interchange278X217Review.Interchange;

namespace X12Interchange278;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "278")]
public class X12Steps278
{
    public static Interchange Deserialize278X217Review(string Document278, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document278, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document278);
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
                        OnUnknownElement = HandleUnknownElement217Review
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "278")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 278");

                SubscriberLevelLoop217Review2000C subscriberLevelLoop217Review2000C = result?.FunctionGroup?.Transaction
                    ?.UMOLevelLoop217Review2000A?.RequesterLevelLoop217Review2000B
                    ?.SubscriberLevelLoop217Review2000C;

                // Inside DependentLevelLoop
                if (subscriberLevelLoop217Review2000C?.DependentLevelLoop217Review2000D?.PatientEventLevelLoop217Review2000E?.PatientEventProviderLoop217Review2010EAForDeserialize != null)
                {
                    subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D
                        .PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EA = subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D
                        .PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize.ToArray();
                    subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D.PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize = null;
                    
                }
                if (subscriberLevelLoop217Review2000C?.DependentLevelLoop217Review2000D?.PatientEventLevelLoop217Review2000E?.ServiceLevelLoop217Review2000FForDeserialize != null)
                {
                    subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D.PatientEventLevelLoop217Review2000E
                        .ServiceLevelLoop217Review2000F = subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D
                        .PatientEventLevelLoop217Review2000E
                        .ServiceLevelLoop217Review2000FForDeserialize.ToArray();
                    subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D
                        .PatientEventLevelLoop217Review2000E
                        .ServiceLevelLoop217Review2000FForDeserialize = null;

                    if (subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D.PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000F != null)
                    {
                        foreach (var t in subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D
                                     .PatientEventLevelLoop217Review2000E
                                     .ServiceLevelLoop217Review2000F)
                        {
                            if (t.ServiceProviderLoop217Review2010FForDeserialize != null)
                            {
                                t.ServiceProviderLoop217Review2010F =
                                    t.ServiceProviderLoop217Review2010FForDeserialize.ToArray();
                                t.ServiceProviderLoop217Review2010FForDeserialize = null;
                            }
                        }
                    }
                }
                
                if (subscriberLevelLoop217Review2000C?.PatientEventLevelLoop217Review2000E?.PatientEventProviderLoop217Review2010EAForDeserialize != null)
                {
                    subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EA = subscriberLevelLoop217Review2000C
                        .PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize.ToArray();
                    subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize = null;
                }
                if (subscriberLevelLoop217Review2000C?.PatientEventLevelLoop217Review2000E?.ServiceLevelLoop217Review2000FForDeserialize != null)
                {
                    subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000F = subscriberLevelLoop217Review2000C
                        .PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000FForDeserialize.ToArray();
                    subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000FForDeserialize = null;

                    if (subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000F != null)
                    {
                        foreach (var t in subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000F)
                        {
                            if (t.ServiceProviderLoop217Review2010FForDeserialize != null)
                            {
                                t.ServiceProviderLoop217Review2010F =
                                    t.ServiceProviderLoop217Review2010FForDeserialize.ToArray();
                                t.ServiceProviderLoop217Review2010FForDeserialize = null;
                            }
                        }
                    }
                }
        
                return result;
            }
        }
    }

    private static void HandleUnknownElement217Review(object obj, XmlElementEventArgs args)
    {
        if ((bool)!args?.Element?.Name?.Contains("Loop"))
            return;
        
        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "2000A": // UMOLevelLoop
            {
                Transaction217Review transaction = args?.ObjectBeingDeserialized as Transaction217Review;
                if(transaction == null)
                    throw new InvalidOperationException("Expected LoopId 2000A to be UMOLevelLoop inside Transaction");
                
                UMOLevelLoop217Review2000A loop217Review2000A = GetLoopValue<UMOLevelLoop217Review2000A>(args.Element);

                transaction.UMOLevelLoop217Review2000A = loop217Review2000A;
            }
            break;
            case "2010A": // UMONameLoop
            {
                UMOLevelLoop217Review2000A umoLevelLoop217Review2000A = args?.ObjectBeingDeserialized as UMOLevelLoop217Review2000A;
                if (umoLevelLoop217Review2000A == null)
                    throw new InvalidOperationException("Expected LoopId 2010A to be UMONameLoop inside UMOLevelLoop");

                UMONameLoop217Review2010A loop217Review2010A = GetLoopValue<UMONameLoop217Review2010A>(args.Element);

                umoLevelLoop217Review2000A.UMONameLoop217Review2010A = loop217Review2010A;
            }
            break;
            case "2000B": // RequesterLevelLoop
            {
                UMOLevelLoop217Review2000A umoLevelLoop217Review2000A = args?.ObjectBeingDeserialized as UMOLevelLoop217Review2000A;
                if (umoLevelLoop217Review2000A == null)
                    throw new InvalidOperationException("Expected LoopId 2000B to be RequesterLevelLoop inside UMOLevelLoop");

                RequesterLevelLoop217Review2000B loop217Review2000B =
                    GetLoopValue<RequesterLevelLoop217Review2000B>(args.Element);

                umoLevelLoop217Review2000A.RequesterLevelLoop217Review2000B = loop217Review2000B;
            }
            break;
            case "2010B": // RequesterNameLoop
            {
                RequesterLevelLoop217Review2000B requesterLevelLoop217Review2000B = args?.ObjectBeingDeserialized as RequesterLevelLoop217Review2000B;
                if (requesterLevelLoop217Review2000B == null)
                    throw new InvalidOperationException("Expected LoopId 2010B to be RequesterNameLoop inside RequesterLevelLoop");
                RequesterNameLoop217Review2010B loop217Review2010B =
                    GetLoopValue<RequesterNameLoop217Review2010B>(args.Element);

                requesterLevelLoop217Review2000B.RequesterNameLoop217Review2010B = loop217Review2010B;
            }
            break;
            case "2000C": // SubscriberLevelLoop
            {
                RequesterLevelLoop217Review2000B requesterLevelLoop217Review2000B = args?.ObjectBeingDeserialized as RequesterLevelLoop217Review2000B;
                if (requesterLevelLoop217Review2000B == null)
                    throw new InvalidOperationException("Expected LoopId 2000C to be SubscriberLevelLoop inside RequesterLevelLoop");
                
                SubscriberLevelLoop217Review2000C loop217Review2000C =
                    GetLoopValue<SubscriberLevelLoop217Review2000C>(args.Element);

                requesterLevelLoop217Review2000B.SubscriberLevelLoop217Review2000C = loop217Review2000C;
            }
            break;
            case "2010C": // SubscriberNameLoop
            {
                SubscriberLevelLoop217Review2000C subscriberLevelLoop217Review2000C = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review2000C;

                if (subscriberLevelLoop217Review2000C == null)
                    throw new InvalidOperationException("Expected LoopId 2010C to be SubscriberNameLoop inside SubscriberLevelLoop");
                
                SubscriberNameLoop217Review2010C loop217Review2010C =
                    GetLoopValue<SubscriberNameLoop217Review2010C>(args.Element);

                subscriberLevelLoop217Review2000C.SubscriberNameLoop217Review2010C = loop217Review2010C;
            }
            break;
            case "2000D": // DependentLevelLoop
            {
                SubscriberLevelLoop217Review2000C subscriberLevelLoop217Review2000C = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review2000C;

                if (subscriberLevelLoop217Review2000C == null)
                    throw new InvalidOperationException("Expected LoopId 2000D to be DependentLevelLoop inside SubscriberLevelLoop");
                
                DependentLevelLoop217Review2000D loop217Review2000D =
                    GetLoopValue<DependentLevelLoop217Review2000D>(args.Element);

                subscriberLevelLoop217Review2000C.DependentLevelLoop217Review2000D = loop217Review2000D;
            }
            break;
            case "2010D": // DependentNameLoop
            {
                DependentLevelLoop217Review2000D dependentLevelLoop217Review2000D = args?.ObjectBeingDeserialized as DependentLevelLoop217Review2000D;

                if (dependentLevelLoop217Review2000D == null)
                    throw new InvalidOperationException("Expected LoopId 2010D to be DependentNameLoop inside DependentLevelLoop");
                
                DependentNameLoop217Review2010D loop217Review2010D =
                    GetLoopValue<DependentNameLoop217Review2010D>(args.Element);

                dependentLevelLoop217Review2000D.DependentNameLoop217Review2010D = loop217Review2010D;
            }
            break;
            case "2000E": // PatientEventLevelLoop
            {
                DependentLevelLoop217Review2000D dependentLevelLoop217Review2000D = args?.ObjectBeingDeserialized as DependentLevelLoop217Review2000D;
                SubscriberLevelLoop217Review2000C subscriberLevelLoop217Review2000C = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review2000C;
                
                if (dependentLevelLoop217Review2000D != null)
                {
                    PatientEventLevelLoop217Review2000E loop217Review2000E =
                        GetLoopValue<PatientEventLevelLoop217Review2000E>(args.Element);

                    dependentLevelLoop217Review2000D.PatientEventLevelLoop217Review2000E = loop217Review2000E;
                }
                else if (subscriberLevelLoop217Review2000C != null)
                {
                    PatientEventLevelLoop217Review2000E loop217Review2000E =
                        GetLoopValue<PatientEventLevelLoop217Review2000E>(args.Element);

                    subscriberLevelLoop217Review2000C.PatientEventLevelLoop217Review2000E = loop217Review2000E;
                }
            }
            break;
            case "2010EA": // PatientEventProviderLoop
            {
                PatientEventLevelLoop217Review2000E patientEventLevelLoop217Review2000E = args?.ObjectBeingDeserialized as PatientEventLevelLoop217Review2000E;

                if (patientEventLevelLoop217Review2000E == null)
                    throw new InvalidOperationException("Expected LoopId 2010EA to be PatientEventProviderLoop inside PatientEventLevelLoop");

                PatientEventProviderLoop217Review2010EA loop217Review2010EA =
                    GetLoopValue<PatientEventProviderLoop217Review2010EA>(args.Element);

                if (patientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize == null)
                    patientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize =
                        new List<PatientEventProviderLoop217Review2010EA>();
                
                patientEventLevelLoop217Review2000E.PatientEventProviderLoop217Review2010EAForDeserialize.Add(loop217Review2010EA);
            }
            break;
            case "2000F": // ServiceLevelLoop
            {
                PatientEventLevelLoop217Review2000E patientEventLevelLoop217Review2000E = args?.ObjectBeingDeserialized as PatientEventLevelLoop217Review2000E;
                if (patientEventLevelLoop217Review2000E == null)
                    throw new InvalidOperationException("Expected LoopId 2000F to be ServiceLevelLoop inside PatientEventLevelLoop");

                ServiceLevelLoop217Review2000F loop217Review2000F =
                    GetLoopValue<ServiceLevelLoop217Review2000F>(args.Element);

                if (patientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000FForDeserialize == null)
                    patientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000FForDeserialize =
                        new List<ServiceLevelLoop217Review2000F>();
                
                patientEventLevelLoop217Review2000E.ServiceLevelLoop217Review2000FForDeserialize.Add(loop217Review2000F);
            }
            break;
            case "2010F": // ServiceProviderLoop
            {
                ServiceLevelLoop217Review2000F serviceLevelLoop217Review2000F = args?.ObjectBeingDeserialized as ServiceLevelLoop217Review2000F;
                if (serviceLevelLoop217Review2000F == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010F to be ServiceProviderLoop inside ServiceLevelLoop");

                ServiceProviderLoop217Review2010F loop217Review2010F =
                    GetLoopValue<ServiceProviderLoop217Review2010F>(args.Element);

                if (serviceLevelLoop217Review2000F.ServiceProviderLoop217Review2010FForDeserialize == null)
                    serviceLevelLoop217Review2000F.ServiceProviderLoop217Review2010FForDeserialize =
                        new List<ServiceProviderLoop217Review2010F>();
                
                serviceLevelLoop217Review2000F.ServiceProviderLoop217Review2010FForDeserialize.Add(loop217Review2010F);
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
                  OnUnknownElement = HandleUnknownElement217Review
              });

              return loop;
          }
      }
}