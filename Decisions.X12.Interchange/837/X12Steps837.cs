using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace X12Interchange837;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "837")]
public class X12Steps837
{
    public static Interchange Deserialize837EDI(string Document837, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (var fs = inputIsPath
                   ? new FileStream(Document837, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document837);
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

                ValidateInterchange(result);
                DeserializeHierarchicalLoops(result);

                return result;
            }
        }
    }

    private static void ValidateInterchange(Interchange result)
    {
        if (result?.FunctionGroup?.Transactions.Any(t => t.ST.ST01 != "837") ?? true)
            throw new InvalidOperationException("Incorrect document being used. Please use 837");
    }

    // 1000A Loop
    private static void DeserializeHierarchicalLoops(Interchange result)
    {
        if (result?.FunctionGroup?.Transaction?.BillingProviderHierarchicalLevelLoop222ForDeserialize != null)
        {
            result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222 =
                result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize.ToArray();
            result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize = null;

            foreach (var billingProvider in result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222)
                // 2000A Loop
                DeserializeSubscriberHierarchicalLoop(billingProvider);
        }
    }

    // 2000A Loop
    private static void DeserializeSubscriberHierarchicalLoop(BillingProviderHierarchicalLevelLoop222 billingProvider)
    {
        if (billingProvider.SubscriberHierarchicalLevelLoop222ForDeserialize != null)
        {
            billingProvider.SubscriberHierarchicalLevelLoop222 =
                billingProvider.SubscriberHierarchicalLevelLoop222ForDeserialize.ToArray();
            billingProvider.SubscriberHierarchicalLevelLoop222ForDeserialize = null;

            foreach (var subscriber in billingProvider.SubscriberHierarchicalLevelLoop222)
                // 2000B Loop
                DeserializePatientHierarchicalLoop(subscriber);
        }
    }

    // 2000B Loop
    private static void DeserializePatientHierarchicalLoop(SubscriberHierarchicalLevelLoop222 subscriber)
    {
        if (subscriber.PatientHierarchicalLoop222ForDeserialize != null)
        {
            subscriber.PatientHierarchicalLoop222 = subscriber.PatientHierarchicalLoop222ForDeserialize.ToArray();
            subscriber.PatientHierarchicalLoop222ForDeserialize = null;

            foreach (var patient in subscriber.PatientHierarchicalLoop222)
                // 2300 Loop
                DeserializePatientClaimInformationLoop(patient);
        }

        if (subscriber.ClaimInformationLoopForDeserialize != null)
        {
            subscriber.ClaimInformationLoop222 = subscriber.ClaimInformationLoopForDeserialize.ToArray();
            subscriber.ClaimInformationLoopForDeserialize = null;

            foreach (var claimInfo in subscriber.ClaimInformationLoop222)
                DeserializeSubscriberClaimInformationLoop(claimInfo);
        }
    }

    private static void DeserializeSubscriberClaimInformationLoop(ClaimInformationLoop222 claimInfo)
    {
        if (claimInfo != null)
        {
            // 2310A Loop
            DeserializeReferringProviderLoop(claimInfo);
            // 2320 Loop
            DeserializeOtherSubscriberInformationLoop(claimInfo);
            // 2400 Loop
            DeserializeServiceLineNumberLoop(claimInfo);
        }
    }

    // 2300 Loop
    private static void DeserializePatientClaimInformationLoop(PatientHierarchicalLoop222 patient)
    {
        if (patient.ClaimInformationLoopForDeserialize != null)
        {
            patient.ClaimInformationLoop222 = patient.ClaimInformationLoopForDeserialize.ToArray();
            patient.ClaimInformationLoopForDeserialize = null;
        }

        foreach (var claimInfo in patient.ClaimInformationLoop222)
        {
            // 2310A Loop
            DeserializeReferringProviderLoop(claimInfo);
            // 2320 Loop
            DeserializeOtherSubscriberInformationLoop(claimInfo);
            // 2400 Loop
            DeserializeServiceLineNumberLoop(claimInfo);
        }
    }

    // 2310 Loop
    private static void DeserializeReferringProviderLoop(ClaimInformationLoop222 claimInfo)
    {
        if (claimInfo.ReferringProviderNameLoop222ForDeserialize != null)
        {
            claimInfo.ReferringProviderNameLoop222 = claimInfo.ReferringProviderNameLoop222ForDeserialize.ToArray();
            claimInfo.ReferringProviderNameLoop222ForDeserialize = null;
        }
    }

    // 2320 Loop
    private static void DeserializeOtherSubscriberInformationLoop(ClaimInformationLoop222 claimInfo)
    {
        if (claimInfo.OtherSubscriberInformationLoop222ForDeserialize != null)
        {
            claimInfo.OtherSubscriberInformationLoop222 =
                claimInfo.OtherSubscriberInformationLoop222ForDeserialize.ToArray();
            claimInfo.OtherSubscriberInformationLoop222ForDeserialize = null;

            foreach (var otherSubscriber in claimInfo.OtherSubscriberInformationLoop222)
                if (otherSubscriber.OtherPayerReferringProviderLoop222ForDeserialize != null)
                {
                    otherSubscriber.OtherPayerReferringProviderLoop222 =
                        otherSubscriber.OtherPayerReferringProviderLoop222ForDeserialize.ToArray();
                    otherSubscriber.OtherPayerReferringProviderLoop222ForDeserialize = null;
                }
        }
    }

    // 2400 Loop
    private static void DeserializeServiceLineNumberLoop(ClaimInformationLoop222 claimInfo)
    {
        if (claimInfo.ServiceLineNumberLoop222ForDeserialize != null)
        {
            claimInfo.ServiceLineNumberLoop222 = claimInfo.ServiceLineNumberLoop222ForDeserialize.ToArray();
            claimInfo.ServiceLineNumberLoop222ForDeserialize = null;

            foreach (var serviceLine in claimInfo.ServiceLineNumberLoop222) DeserializeServiceLineDetails(serviceLine);
        }
    }

    private static void DeserializeServiceLineDetails(ServiceLineNumberLoop222 serviceLine)
    {
        // 2420F Loop
        if (serviceLine.ReferringProviderNameLoop222ForDeserialize != null)
        {
            serviceLine.ReferringProviderNameLoop222 = serviceLine.ReferringProviderNameLoop222ForDeserialize.ToArray();
            serviceLine.ReferringProviderNameLoop222ForDeserialize = null;
        }

        // 2430 Loop
        if (serviceLine.LineAdjudicationInformationLoop222ForDeserialize != null)
        {
            serviceLine.LineAdjudicationInformationLoop222 =
                serviceLine.LineAdjudicationInformationLoop222ForDeserialize.ToArray();
            serviceLine.LineAdjudicationInformationLoop222ForDeserialize = null;
        }

        // 2440 Loop
        if (serviceLine.FormIdentificationCodeLoop222ForDeserialize != null)
        {
            serviceLine.FormIdentificationCodeLoop222 =
                serviceLine.FormIdentificationCodeLoop222ForDeserialize.ToArray();
            serviceLine.FormIdentificationCodeLoop222ForDeserialize = null;
        }
    }

    private static void HandleUnknownElement(object obj, XmlElementEventArgs args)
    {
        if ((bool)!args?.Element?.Name?.Contains("Loop"))
            return;

        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "1000A": // SubmitterNameLoop
            {
                var transaction = args?.ObjectBeingDeserialized as Transaction222;
                if (transaction == null)
                    throw new InvalidOperationException("Expected LoopId 1000A to be inside Transaction");

                var loop = GetLoopValue<SubmitterNameLoop222>(args.Element);

                transaction.SubmitterNameLoop222 = loop;
            }
                break;
            case "1000B": // ReceiverNameLoop
            {
                var transaction = args?.ObjectBeingDeserialized as Transaction222;
                if (transaction == null)
                    throw new InvalidOperationException("Expected LoopId 1000B to be inside Transaction");

                var loop = GetLoopValue<ReceiverNameLoop222>(args.Element);

                transaction.ReceiverNameLoop222 = loop;
            }
                break;
            case "2000A": // BillingProviderHierarchicalLevelLoop
            {
                var transaction = args?.ObjectBeingDeserialized as Transaction222;
                if (transaction == null)
                    throw new InvalidOperationException("Expected LoopId 1000B to be inside Transaction");

                var loop = GetLoopValue<BillingProviderHierarchicalLevelLoop222>(args.Element);

                if (transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize == null)
                    transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize =
                        new List<BillingProviderHierarchicalLevelLoop222>();

                transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2010AA": // ProviderNameLoop
            {
                var billingProviderHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                if (billingProviderHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010AA to be inside Billing Provider Hierarchical Level Loop");

                var loop = GetLoopValue<ProviderNameLoop222>(args.Element);

                billingProviderHierarchicalLevelLoop222.ProviderNameLoop222 = loop;
            }
                break;
            case "2010AB": // PayToAddressLoop
            {
                var billingProviderHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                if (billingProviderHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010AB to be inside Billing Provider Hierarchical Level Loop");

                var loop = GetLoopValue<PayToAddressLoop222>(args.Element);

                billingProviderHierarchicalLevelLoop222.PayToAddressLoop222 = loop;
            }
                break;
            case "2010AC": // PayToPlanLoop
            {
                var billingProviderHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                if (billingProviderHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010AC to be inside Billing Provider Hierarchical Level Loop");

                var loop = GetLoopValue<PayToPlanLoop222>(args.Element);

                billingProviderHierarchicalLevelLoop222.PayToPlanLoop222 = loop;
            }
                break;
            case "2000B": // SubscriberHierarchicalLevelLoop222
            {
                var billingProviderHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                if (billingProviderHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2000B to be inside Billing Provider Hierarchical Level Loop");

                var loop = GetLoopValue<SubscriberHierarchicalLevelLoop222>(args.Element);

                if (billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize == null)
                    billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize =
                        new List<SubscriberHierarchicalLevelLoop222>();

                billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2010BA": // SubscriberNameLoop
            {
                var subscriberHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                if (subscriberHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010BA to be inside Subscriber Hierarchical Level Loop");

                var loop = GetLoopValue<SubscriberNameLoop222>(args.Element);

                subscriberHierarchicalLevelLoop222.SubscriberNameLoop222 = loop;
            }
                break;
            case "2010BB": // PayerNameLoop
            {
                var subscriberHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                if (subscriberHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010BB to be inside Subscriber Hierarchical Level Loop");

                var loop = GetLoopValue<PayerNameLoop222>(args.Element);

                subscriberHierarchicalLevelLoop222.PayerNameLoop222 = loop;
            }
                break;
            case "2000C": // PatientHierarchicalLoop
            {
                var subscriberHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                if (subscriberHierarchicalLevelLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2000C to be inside Subscriber Hierarchical Level Loop");

                var loop = GetLoopValue<PatientHierarchicalLoop222>(args.Element);

                if (subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize == null)
                    subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize =
                        new List<PatientHierarchicalLoop222>();

                subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2010CA": // PatientNameLoop
            {
                var patientHierarchicalLoop222 = args?.ObjectBeingDeserialized as PatientHierarchicalLoop222;
                if (patientHierarchicalLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2010CA to be inside Patient Hierarchical Loop");

                var loop = GetLoopValue<PatientNameLoop222>(args.Element);

                patientHierarchicalLoop222.PatientNameLoop222 = loop;
            }
                break;
            case "2300": // ClaimInformationLoop
            {
                var subscriberHierarchicalLevelLoop222 =
                    args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                if (subscriberHierarchicalLevelLoop222 != null)
                {
                    var loop = GetLoopValue<ClaimInformationLoop222>(args.Element);

                    if (subscriberHierarchicalLevelLoop222.ClaimInformationLoopForDeserialize == null)
                        subscriberHierarchicalLevelLoop222.ClaimInformationLoopForDeserialize =
                            new List<ClaimInformationLoop222>();

                    subscriberHierarchicalLevelLoop222.ClaimInformationLoopForDeserialize.Add(loop);
                }

                var patientHierarchicalLoop222 = args?.ObjectBeingDeserialized as PatientHierarchicalLoop222;
                if (patientHierarchicalLoop222 != null)
                {
                    var loop222 = GetLoopValue<ClaimInformationLoop222>(args.Element);

                    if (patientHierarchicalLoop222.ClaimInformationLoopForDeserialize == null)
                        patientHierarchicalLoop222.ClaimInformationLoopForDeserialize =
                            new List<ClaimInformationLoop222>();

                    patientHierarchicalLoop222.ClaimInformationLoopForDeserialize.Add(loop222);
                }
            }
                break;
            case "2310A": // ReferringProviderNameLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310A to be inside Claim Information Loop");

                var loop = GetLoopValue<ReferringProviderNameLoop222>(args.Element);

                if (claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize == null)
                    claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize =
                        new List<ReferringProviderNameLoop222>();

                claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2310B": // RenderingProviderNameLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310B to be inside Claim Information Loop");

                var loop = GetLoopValue<RenderingProviderNameLoop222>(args.Element);

                claimInformationLoop222.RenderingProviderNameLoop222 = loop;
            }
                break;
            case "2310C": // ServiceFacilityLocationNameLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310C to be inside Claim Information Loop");

                var loop = GetLoopValue<ServiceFacilityLocationNameLoop222>(args.Element);

                claimInformationLoop222.ServiceFacilityLocationNameLoop222 = loop;
            }
                break;
            case "2310D": // SupervisingProviderNameLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310D to be inside Claim Information Loop");

                var loop = GetLoopValue<SupervisingProviderNameLoop222>(args.Element);

                claimInformationLoop222.SupervisingProviderNameLoop222 = loop;
            }
                break;
            case "2310E": // AmbulancePickupLocationLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310E to be inside Claim Information Loop");

                var loop = GetLoopValue<AmbulancePickupLocationLoop222>(args.Element);

                claimInformationLoop222.AmbulancePickupLocationLoop222 = loop;
            }
                break;
            case "2310F": // AmbulanceDropoffLocationLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2310F to be inside Claim Information Loop");

                var loop = GetLoopValue<AmbulanceDropoffLocationLoop222>(args.Element);

                claimInformationLoop222.AmbulanceDropoffLocationLoop222 = loop;
            }
                break;
            case "2320": // OtherSubscriberInformationLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2320 to be inside Claim Information Loop");

                var loop = GetLoopValue<OtherSubscriberInformationLoop222>(args.Element);

                if (claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize == null)
                    claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize =
                        new List<OtherSubscriberInformationLoop222>();

                claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2330A": // OtherSubscriberNameLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330A to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherSubscriberNameLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherSubscriberNameLoop222 = loop;
            }
                break;
            case "2330B": // OtherPayerNameLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330B to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerNameLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherPayerNameLoop222 = loop;
            }
                break;
            case "2330C": // OtherPayerReferringProviderLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330C to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerReferringProviderLoop222>(args.Element);

                if (otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize == null)
                    otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize =
                        new List<OtherPayerReferringProviderLoop222>();

                otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2330D": // OtherPayerRenderingProviderLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330D to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerRenderingProviderLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherPayerRenderingProviderLoop222 = loop;
            }
                break;
            case "2330E": // OtherPayerServiceFacilityLocationLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330E to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerServiceFacilityLocationLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherPayerServiceFacilityLocationLoop222 = loop;
            }
                break;
            case "2330F": // OtherPayerSupervisingProviderLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330F to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerSupervisingProviderLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherPayerSupervisingProviderLoop222 = loop;
            }
                break;
            case "2330G": // OtherPayerBillingProviderLoop
            {
                var otherSubscriberInformationLoop222 =
                    args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                if (otherSubscriberInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2330G to be inside Other Subscriber Information Loop");

                var loop = GetLoopValue<OtherPayerBillingProviderLoop222>(args.Element);

                otherSubscriberInformationLoop222.OtherPayerBillingProviderLoop222 = loop;
            }
                break;
            case "2400": // ServiceLineNumberLoop
            {
                var claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                if (claimInformationLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2400 to be inside Claim Information Loop");

                var loop = GetLoopValue<ServiceLineNumberLoop222>(args.Element);

                if (claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize == null)
                    claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize =
                        new List<ServiceLineNumberLoop222>();

                claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2410": // DrugIdentificationLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2410 to be inside Service Line Number Loop");

                var loop = GetLoopValue<DrugIdentificationLoop222>(args.Element);

                serviceLineNumberLoop222.DrugIdentificationLoop222 = loop;
            }
                break;
            case "2420A": // RenderingProviderNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420A to be inside Service Line Number Loop");

                var loop = GetLoopValue<RenderingProviderNameLoop222>(args.Element);

                serviceLineNumberLoop222.RenderingProviderNameLoop222 = loop;
            }
                break;
            case "2420B": // PurchasedServiceProviderNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420B to be inside Service Line Number Loop");

                var loop = GetLoopValue<PurchasedServiceProviderNameLoop222>(args.Element);

                serviceLineNumberLoop222.PurchasedServiceProviderNameLoop222 = loop;
            }
                break;
            case "2420C": // ServiceFacilityLocationNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420C to be inside Service Line Number Loop");

                var loop = GetLoopValue<ServiceFacilityLocationNameLoop222>(args.Element);

                serviceLineNumberLoop222.ServiceFacilityLocationNameLoop222 = loop;
            }
                break;
            case "2420D": // SupervisingProviderNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420D to be inside Service Line Number Loop");

                var loop = GetLoopValue<SupervisingProviderNameLoop222>(args.Element);

                serviceLineNumberLoop222.SupervisingProviderNameLoop222 = loop;
            }
                break;
            case "2420E": // OrderingProviderNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420E to be inside Service Line Number Loop");

                var loop = GetLoopValue<OrderingProviderNameLoop222>(args.Element);

                serviceLineNumberLoop222.OrderingProviderNameLoop222 = loop;
            }
                break;
            case "2420F": // ReferringProviderNameLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420F to be inside Service Line Number Loop");

                var loop = GetLoopValue<ReferringProviderNameLoop222>(args.Element);

                if (serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize == null)
                    serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize =
                        new List<ReferringProviderNameLoop222>();

                serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2420G": // AmbulancePickupLocationLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420G to be inside Service Line Number Loop");

                var loop = GetLoopValue<AmbulancePickupLocationLoop222>(args.Element);

                serviceLineNumberLoop222.AmbulancePickupLocationLoop222 = loop;
            }
                break;
            case "2420H": // AmbulanceDropoffLocationLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2420H to be inside Service Line Number Loop");

                var loop = GetLoopValue<AmbulanceDropoffLocationLoop222>(args.Element);

                serviceLineNumberLoop222.AmbulanceDropoffLocationLoop222 = loop;
            }
                break;
            case "2430": // LineAdjudicationInformationLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2430 to be inside Service Line Number Loop");

                var loop = GetLoopValue<LineAdjudicationInformationLoop222>(args.Element);

                if (serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize == null)
                    serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize =
                        new List<LineAdjudicationInformationLoop222>();

                serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize.Add(loop);
            }
                break;
            case "2440": // FormIdentificationCodeLoop
            {
                var serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                if (serviceLineNumberLoop222 == null)
                    throw new InvalidOperationException(
                        "Expected LoopId 2440 to be inside Service Line Number Loop");

                var loop = GetLoopValue<FormIdentificationCodeLoop222>(args.Element);

                if (serviceLineNumberLoop222.FormIdentificationCodeLoop222ForDeserialize == null)
                    serviceLineNumberLoop222.FormIdentificationCodeLoop222ForDeserialize =
                        new List<FormIdentificationCodeLoop222>();

                serviceLineNumberLoop222.FormIdentificationCodeLoop222ForDeserialize.Add(loop);
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