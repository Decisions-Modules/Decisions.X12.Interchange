using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using X12Interchange835;

namespace X12Interchange837;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "837")]
public class X12Steps837
{
    public static Interchange Deserialize837EDI(string Document837, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(Document837, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(Document837);
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

                if (result?.FunctionGroup?.Transaction?.ST.ST01 != "837")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 837");

                if (result?.FunctionGroup?.Transaction?.BillingProviderHierarchicalLevelLoop222ForDeserialize != null)
                {
                    result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222 = result.FunctionGroup
                        .Transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize.ToArray();
                    result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize = null;
                    
                    if (result?.FunctionGroup?.Transaction?.BillingProviderHierarchicalLevelLoop222 != null)
                    {
                        foreach (var t in result.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222)
                        {
                            if (t.SubscriberHierarchicalLevelLoop222ForDeserialize != null)
                            {
                                t.SubscriberHierarchicalLevelLoop222 = t.SubscriberHierarchicalLevelLoop222ForDeserialize.ToArray();
                                t.SubscriberHierarchicalLevelLoop222ForDeserialize = null;
                                
                                if (t.SubscriberHierarchicalLevelLoop222 != null)
                                {
                                    foreach (var s in t.SubscriberHierarchicalLevelLoop222)
                                    {
                                        if (s.PatientHierarchicalLoop222ForDeserialize != null)
                                        {
                                            s.PatientHierarchicalLoop222 = s.PatientHierarchicalLoop222ForDeserialize.ToArray();
                                            s.PatientHierarchicalLoop222ForDeserialize = null;
                                        }

                                        if (s.PatientHierarchicalLoop222 != null)
                                        {
                                            foreach (var r in s.PatientHierarchicalLoop222)
                                            {
                                                if (r.ClaimInformationLoopForDeserialize != null)
                                                {
                                                    r.ClaimInformationLoop222 = r.ClaimInformationLoopForDeserialize.ToArray();
                                                    r.ClaimInformationLoopForDeserialize = null;
                                                }
                                                
                                                if (r.ClaimInformationLoop222 != null)
                                                {
                                                    foreach (var q in r.ClaimInformationLoop222)
                                                    {
                                                        if (q.ReferringProviderNameLoop222ForDeserialize != null)
                                                        {
                                                            q.ReferringProviderNameLoop222 = q.ReferringProviderNameLoop222ForDeserialize.ToArray();
                                                            q.ReferringProviderNameLoop222ForDeserialize = null;
                                                        }

                                                        if (q.OtherSubscriberInformationLoop222ForDeserialize != null)
                                                        {
                                                            q.OtherSubscriberInformationLoop222 = q.OtherSubscriberInformationLoop222ForDeserialize.ToArray();
                                                            q.OtherSubscriberInformationLoop222ForDeserialize = null;
                                                        }

                                                        if (q.OtherSubscriberInformationLoop222 != null)
                                                        {
                                                            foreach (var p in q.OtherSubscriberInformationLoop222)
                                                            {
                                                                if (p.OtherPayerReferringProviderLoop222ForDeserialize != null)
                                                                {
                                                                    p.OtherPayerReferringProviderLoop222 = p.OtherPayerReferringProviderLoop222ForDeserialize.ToArray();
                                                                    p.OtherPayerReferringProviderLoop222ForDeserialize = null;
                                                                }
                                                            }
                                                        }

                                                        if (q.ServiceLineNumberLoop222ForDeserialize != null)
                                                        {
                                                            q.ServiceLineNumberLoop222 = q.ServiceLineNumberLoop222ForDeserialize.ToArray();
                                                            q.ServiceLineNumberLoop222ForDeserialize = null;

                                                            if (q.ServiceLineNumberLoop222 != null)
                                                            {
                                                                foreach (var o in q.ServiceLineNumberLoop222)
                                                                {
                                                                    if (o.ReferringProviderNameLoop222ForDeserialize != null)
                                                                    {
                                                                        o.ReferringProviderNameLoop222 = o.ReferringProviderNameLoop222ForDeserialize.ToArray();
                                                                        o.ReferringProviderNameLoop222ForDeserialize = null;
                                                                    }

                                                                    if (o.LineAdjudicationInformationLoop222ForDeserialize != null)
                                                                    {
                                                                        o.LineAdjudicationInformationLoop222 = o.LineAdjudicationInformationLoop222ForDeserialize.ToArray();
                                                                        o.LineAdjudicationInformationLoop222ForDeserialize = null;
                                                                    }

                                                                    if (o.FormIdentificationCodeLoop222ForDeserialize != null)
                                                                    {
                                                                        o.FormIdentificationCodeLoop222 = o.FormIdentificationCodeLoop222ForDeserialize.ToArray();
                                                                        o.FormIdentificationCodeLoop222ForDeserialize = null;
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
                case "1000A": // SubmitterNameLoop
                {
                    Transaction222 transaction = args?.ObjectBeingDeserialized as Transaction222;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000A to be inside Transaction");
                    
                    SubmitterNameLoop222 loop = GetLoopValue<SubmitterNameLoop222>(args.Element);

                    transaction.SubmitterNameLoop222 = loop;
                } 
                break;
                case "1000B": // ReceiverNameLoop
                {
                    Transaction222 transaction = args?.ObjectBeingDeserialized as Transaction222;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000B to be inside Transaction");
                    
                    ReceiverNameLoop222 loop = GetLoopValue<ReceiverNameLoop222>(args.Element);

                    transaction.ReceiverNameLoop222 = loop;
                } 
                break;
                case "2000A": // BillingProviderHierarchicalLevelLoop
                {
                    Transaction222 transaction = args?.ObjectBeingDeserialized as Transaction222;
                    if(transaction == null)
                        throw new InvalidOperationException("Expected LoopId 1000B to be inside Transaction");
                    
                    BillingProviderHierarchicalLevelLoop222 loop = GetLoopValue<BillingProviderHierarchicalLevelLoop222>(args.Element);

                    if (transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize == null)
                        transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize =
                            new List<BillingProviderHierarchicalLevelLoop222>();

                    transaction.BillingProviderHierarchicalLevelLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2010AA": // ProviderNameLoop
                {
                    BillingProviderHierarchicalLevelLoop222 billingProviderHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                    if(billingProviderHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010AA to be inside Billing Provider Hierarchical Level Loop");
                    
                    ProviderNameLoop222 loop = GetLoopValue<ProviderNameLoop222>(args.Element);

                    billingProviderHierarchicalLevelLoop222.ProviderNameLoop222 = loop;
                } 
                break;
                case "2010AB": // PayToAddressLoop
                {
                    BillingProviderHierarchicalLevelLoop222 billingProviderHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                    if(billingProviderHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010AB to be inside Billing Provider Hierarchical Level Loop");
                    
                    PayToAddressLoop222 loop = GetLoopValue<PayToAddressLoop222>(args.Element);

                    billingProviderHierarchicalLevelLoop222.PayToAddressLoop222 = loop;
                } 
                break;
                case "2010AC": // PayToPlanLoop
                {
                    BillingProviderHierarchicalLevelLoop222 billingProviderHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                    if(billingProviderHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010AC to be inside Billing Provider Hierarchical Level Loop");
                    
                    PayToPlanLoop222 loop = GetLoopValue<PayToPlanLoop222>(args.Element);

                    billingProviderHierarchicalLevelLoop222.PayToPlanLoop222 = loop;
                } 
                break;
                case "2000B": // SubscriberHierarchicalLevelLoop222
                {
                    BillingProviderHierarchicalLevelLoop222 billingProviderHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as BillingProviderHierarchicalLevelLoop222;
                    if(billingProviderHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2000B to be inside Billing Provider Hierarchical Level Loop");
                    
                    SubscriberHierarchicalLevelLoop222 loop = GetLoopValue<SubscriberHierarchicalLevelLoop222>(args.Element);

                    if (billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize == null)
                        billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize =
                            new List<SubscriberHierarchicalLevelLoop222>();

                    billingProviderHierarchicalLevelLoop222.SubscriberHierarchicalLevelLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2010BA": // SubscriberNameLoop
                {
                    SubscriberHierarchicalLevelLoop222 subscriberHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                    if(subscriberHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010BA to be inside Subscriber Hierarchical Level Loop");
                    
                    SubscriberNameLoop222 loop = GetLoopValue<SubscriberNameLoop222>(args.Element);

                    subscriberHierarchicalLevelLoop222.SubscriberNameLoop222 = loop;
                } 
                break;
                case "2010BB": // PayerNameLoop
                {
                    SubscriberHierarchicalLevelLoop222 subscriberHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                    if(subscriberHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010BB to be inside Subscriber Hierarchical Level Loop");
                    
                    PayerNameLoop222 loop = GetLoopValue<PayerNameLoop222>(args.Element);

                    subscriberHierarchicalLevelLoop222.PayerNameLoop222 = loop;
                } 
                break;
                case "2000C": // PatientHierarchicalLoop
                {
                    SubscriberHierarchicalLevelLoop222 subscriberHierarchicalLevelLoop222 = args?.ObjectBeingDeserialized as SubscriberHierarchicalLevelLoop222;
                    if(subscriberHierarchicalLevelLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2000C to be inside Subscriber Hierarchical Level Loop");
                    
                    PatientHierarchicalLoop222 loop = GetLoopValue<PatientHierarchicalLoop222>(args.Element);

                    if (subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize == null)
                        subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize =
                            new List<PatientHierarchicalLoop222>();
                    
                    subscriberHierarchicalLevelLoop222.PatientHierarchicalLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2010CA": // PatientNameLoop
                {
                    PatientHierarchicalLoop222 patientHierarchicalLoop222 = args?.ObjectBeingDeserialized as PatientHierarchicalLoop222;
                    if(patientHierarchicalLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2010CA to be inside Patient Hierarchical Loop");
                    
                    PatientNameLoop222 loop = GetLoopValue<PatientNameLoop222>(args.Element);

                    patientHierarchicalLoop222.PatientNameLoop222 = loop;
                } 
                break;
                case "2300": // ClaimInformationLoop
                {
                    PatientHierarchicalLoop222 patientHierarchicalLoop222 = args?.ObjectBeingDeserialized as PatientHierarchicalLoop222;
                    if(patientHierarchicalLoop222 == null)
                        throw new InvalidOperationException("Expected LoopId 2300 to be inside Patient Hierarchical Loop");
                    
                    ClaimInformationLoop222 loop222 = GetLoopValue<ClaimInformationLoop222>(args.Element);

                    if (patientHierarchicalLoop222.ClaimInformationLoopForDeserialize == null)
                        patientHierarchicalLoop222.ClaimInformationLoopForDeserialize =
                            new List<ClaimInformationLoop222>();

                    patientHierarchicalLoop222.ClaimInformationLoopForDeserialize.Add(loop222);
                } 
                break;
                case "2310A": // ReferringProviderNameLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310A to be inside Claim Information Loop");

                    ReferringProviderNameLoop222 loop = GetLoopValue<ReferringProviderNameLoop222>(args.Element);

                    if (claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize == null)
                        claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize =
                            new List<ReferringProviderNameLoop222>();
                    
                    claimInformationLoop222.ReferringProviderNameLoop222ForDeserialize.Add(loop);
                }
                break;
                case "2310B": // RenderingProviderNameLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310B to be inside Claim Information Loop");

                    RenderingProviderNameLoop222 loop = GetLoopValue<RenderingProviderNameLoop222>(args.Element);

                    claimInformationLoop222.RenderingProviderNameLoop222 = loop;
                }
                break;
                case "2310C": // ServiceFacilityLocationNameLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310C to be inside Claim Information Loop");

                    ServiceFacilityLocationNameLoop222 loop = GetLoopValue<ServiceFacilityLocationNameLoop222>(args.Element);

                    claimInformationLoop222.ServiceFacilityLocationNameLoop222 = loop;
                }
                break;
                case "2310D": // SupervisingProviderNameLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310D to be inside Claim Information Loop");

                    SupervisingProviderNameLoop222 loop = GetLoopValue<SupervisingProviderNameLoop222>(args.Element);

                    claimInformationLoop222.SupervisingProviderNameLoop222 = loop;
                }
                break;
                case "2310E": // AmbulancePickupLocationLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310E to be inside Claim Information Loop");

                    AmbulancePickupLocationLoop222 loop = GetLoopValue<AmbulancePickupLocationLoop222>(args.Element);

                    claimInformationLoop222.AmbulancePickupLocationLoop222 = loop;
                }
                break;
                case "2310F": // AmbulanceDropoffLocationLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2310F to be inside Claim Information Loop");

                    AmbulanceDropoffLocationLoop222 loop = GetLoopValue<AmbulanceDropoffLocationLoop222>(args.Element);

                    claimInformationLoop222.AmbulanceDropoffLocationLoop222 = loop;
                }
                break;
                case "2320": // OtherSubscriberInformationLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2320 to be inside Claim Information Loop");

                    OtherSubscriberInformationLoop222 loop = GetLoopValue<OtherSubscriberInformationLoop222>(args.Element);

                    if (claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize == null)
                        claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize =
                            new List<OtherSubscriberInformationLoop222>();
                    
                    claimInformationLoop222.OtherSubscriberInformationLoop222ForDeserialize.Add(loop);
                }
                break;
                case "2330A": // OtherSubscriberNameLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330A to be inside Other Subscriber Information Loop");

                    OtherSubscriberNameLoop222 loop = GetLoopValue<OtherSubscriberNameLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherSubscriberNameLoop222 = loop;
                }
                break;
                case "2330B": // OtherPayerNameLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330B to be inside Other Subscriber Information Loop");

                    OtherPayerNameLoop222 loop = GetLoopValue<OtherPayerNameLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherPayerNameLoop222 = loop;
                }
                break;
                case "2330C": // OtherPayerReferringProviderLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330C to be inside Other Subscriber Information Loop");

                    OtherPayerReferringProviderLoop222 loop = GetLoopValue<OtherPayerReferringProviderLoop222>(args.Element);

                    if (otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize == null)
                        otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize =
                            new List<OtherPayerReferringProviderLoop222>();

                    otherSubscriberInformationLoop222.OtherPayerReferringProviderLoop222ForDeserialize.Add(loop);
                }
                break;
                case "2330D": // OtherPayerRenderingProviderLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330D to be inside Other Subscriber Information Loop");

                    OtherPayerRenderingProviderLoop222 loop = GetLoopValue<OtherPayerRenderingProviderLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherPayerRenderingProviderLoop222 = loop;
                }
                break;
                case "2330E": // OtherPayerServiceFacilityLocationLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330E to be inside Other Subscriber Information Loop");

                    OtherPayerServiceFacilityLocationLoop222 loop = GetLoopValue<OtherPayerServiceFacilityLocationLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherPayerServiceFacilityLocationLoop222 = loop;
                }
                break;
                case "2330F": // OtherPayerSupervisingProviderLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330F to be inside Other Subscriber Information Loop");

                    OtherPayerSupervisingProviderLoop222 loop = GetLoopValue<OtherPayerSupervisingProviderLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherPayerSupervisingProviderLoop222 = loop;
                }
                break;
                case "2330G": // OtherPayerBillingProviderLoop
                {
                    OtherSubscriberInformationLoop222 otherSubscriberInformationLoop222 = args?.ObjectBeingDeserialized as OtherSubscriberInformationLoop222;

                    if (otherSubscriberInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2330G to be inside Other Subscriber Information Loop");

                    OtherPayerBillingProviderLoop222 loop = GetLoopValue<OtherPayerBillingProviderLoop222>(args.Element);

                    otherSubscriberInformationLoop222.OtherPayerBillingProviderLoop222 = loop;
                }
                break;
                case "2400": // ServiceLineNumberLoop
                {
                    ClaimInformationLoop222 claimInformationLoop222 = args?.ObjectBeingDeserialized as ClaimInformationLoop222;

                    if (claimInformationLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2400 to be inside Claim Information Loop");

                    ServiceLineNumberLoop222 loop = GetLoopValue<ServiceLineNumberLoop222>(args.Element);

                    if (claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize == null)
                        claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize =
                            new List<ServiceLineNumberLoop222>();
                    
                    claimInformationLoop222.ServiceLineNumberLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2410": // DrugIdentificationLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2410 to be inside Service Line Number Loop");

                    DrugIdentificationLoop222 loop = GetLoopValue<DrugIdentificationLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.DrugIdentificationLoop222 = loop;
                } 
                break;
                case "2420A": // RenderingProviderNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420A to be inside Service Line Number Loop");

                    RenderingProviderNameLoop222 loop = GetLoopValue<RenderingProviderNameLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.RenderingProviderNameLoop222 = loop;
                } 
                break;
                case "2420B": // PurchasedServiceProviderNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420B to be inside Service Line Number Loop");

                    PurchasedServiceProviderNameLoop222 loop = GetLoopValue<PurchasedServiceProviderNameLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.PurchasedServiceProviderNameLoop222 = loop;
                } 
                break;
                case "2420C": // ServiceFacilityLocationNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420C to be inside Service Line Number Loop");

                    ServiceFacilityLocationNameLoop222 loop = GetLoopValue<ServiceFacilityLocationNameLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.ServiceFacilityLocationNameLoop222 = loop;
                } 
                break;
                case "2420D": // SupervisingProviderNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420D to be inside Service Line Number Loop");

                    SupervisingProviderNameLoop222 loop = GetLoopValue<SupervisingProviderNameLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.SupervisingProviderNameLoop222 = loop;
                } 
                break;
                case "2420E": // OrderingProviderNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420E to be inside Service Line Number Loop");

                    OrderingProviderNameLoop222 loop = GetLoopValue<OrderingProviderNameLoop222>(args.Element);
                    
                    serviceLineNumberLoop222.OrderingProviderNameLoop222 = loop;
                } 
                break;
                case "2420F": // ReferringProviderNameLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420F to be inside Service Line Number Loop");

                    ReferringProviderNameLoop222 loop = GetLoopValue<ReferringProviderNameLoop222>(args.Element);

                    if (serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize == null)
                        serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize =
                            new List<ReferringProviderNameLoop222>();
                    
                    serviceLineNumberLoop222.ReferringProviderNameLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2420G": // AmbulancePickupLocationLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420G to be inside Service Line Number Loop");

                    AmbulancePickupLocationLoop222 loop = GetLoopValue<AmbulancePickupLocationLoop222>(args.Element);

                    serviceLineNumberLoop222.AmbulancePickupLocationLoop222 = loop;
                } 
                break;
                case "2420H": // AmbulanceDropoffLocationLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2420H to be inside Service Line Number Loop");

                    AmbulanceDropoffLocationLoop222 loop = GetLoopValue<AmbulanceDropoffLocationLoop222>(args.Element);

                    serviceLineNumberLoop222.AmbulanceDropoffLocationLoop222 = loop;
                } 
                break;
                case "2430": // LineAdjudicationInformationLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2430 to be inside Service Line Number Loop");
                    
                    LineAdjudicationInformationLoop222 loop = GetLoopValue<LineAdjudicationInformationLoop222>(args.Element);

                    if (serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize == null)
                        serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize =
                            new List<LineAdjudicationInformationLoop222>();
                    
                    serviceLineNumberLoop222.LineAdjudicationInformationLoop222ForDeserialize.Add(loop);
                } 
                break;
                case "2440": // FormIdentificationCodeLoop
                {
                    ServiceLineNumberLoop222 serviceLineNumberLoop222 = args?.ObjectBeingDeserialized as ServiceLineNumberLoop222;

                    if (serviceLineNumberLoop222 == null)
                        throw new InvalidOperationException(
                            "Expected LoopId 2440 to be inside Service Line Number Loop");
                    
                    FormIdentificationCodeLoop222 loop = GetLoopValue<FormIdentificationCodeLoop222>(args.Element);

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