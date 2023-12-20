using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class ServiceLineNumberLoop222 // 2400 Loop
{
    [DataMember, WritableValue, PropertyClassification("Service Line Number", 10)]
    public LX LX { get; set; }
    [DataMember, WritableValue, PropertyClassification("Professional Service", 20)]
    public SV1 SV1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Line Number", 30)]
    public SV5 SV5 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Supplemental Information", 40)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Transport Information", 50)]
    public CR1 CR1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Durable Medical Equipment Certification", 60)]
    public CR3 CR3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Conditions Indicators", 70)]
    [XmlElement("CRC")]
    public CRC[] CRC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Dates", 80)]
    [XmlElement("DTP")]
    public DTP[] DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantities", 90)]
    [XmlElement("QTY")]
    public QTY[] QTY { get; set; }
    [DataMember, WritableValue, PropertyClassification("Test Results", 100)]
    [XmlElement("MEA")]
    public MEA[] MEA { get; set; }
    [DataMember, WritableValue, PropertyClassification("Contract Information", 110)]
    public CN1 CN1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Numbers", 120)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Amounts", 130)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("File Information", 140)]
    [XmlElement("K3")]
    public K3[] K3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Notes", 150)]
    [XmlElement("NTE")]
    public NTE[] NTE { get; set; }
    [DataMember, WritableValue, PropertyClassification("Purchased Service Information", 160)]
    public PS1 PS1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Line Pricing/Repricing Information", 170)]
    public HCP HCP { get; set; }
    
    // 2410 Loop
    [DataMember, WritableValue, PropertyClassification("Drug Identification Loop", 180)]
    public DrugIdentificationLoop222 DrugIdentificationLoop222 { get; set; }
    // 2420A Loop
    [DataMember, WritableValue, PropertyClassification("Rendering Provider Name Loop", 190)]
    public RenderingProviderNameLoop222 RenderingProviderNameLoop222 { get; set; }
    // 2420B Loop
    [DataMember, WritableValue, PropertyClassification("Purchased Service Provider Name Loop", 200)]
    public PurchasedServiceProviderNameLoop222 PurchasedServiceProviderNameLoop222 { get; set; }
    // 2420C Loop
    [DataMember, WritableValue, PropertyClassification("Service Facility Location Name Loop", 210)]
    public ServiceFacilityLocationNameLoop222 ServiceFacilityLocationNameLoop222 { get; set; }
    // 2420D Loop
    [DataMember, WritableValue, PropertyClassification("Supervising Provider Name Loop", 220)]
    public SupervisingProviderNameLoop222 SupervisingProviderNameLoop222 { get; set; }
    // 2420E Loop
    [DataMember, WritableValue, PropertyClassification("Ordering Provider Name Loop", 230)]
    public OrderingProviderNameLoop222 OrderingProviderNameLoop222 { get; set; }
    // 2420F Loop
    [DataMember, WritableValue, PropertyClassification("Referring Provider Name Loop", 240)]
    public ReferringProviderNameLoop222[] ReferringProviderNameLoop222 { get; set; }
    // 2420G Loop
    [DataMember, WritableValue, PropertyClassification("Ambulance Pickup Location Loop", 250)]
    public AmbulancePickupLocationLoop222 AmbulancePickupLocationLoop222 { get; set; }
    // 2420H Loop
    [DataMember, WritableValue, PropertyClassification("Ambulance Dropoff Location Loop", 260)]
    public AmbulanceDropoffLocationLoop222 AmbulanceDropoffLocationLoop222 { get; set; }
    // 2430 Loop
    [DataMember, WritableValue, PropertyClassification("Line Adjudication Information Loop", 270)]
    public LineAdjudicationInformationLoop222[] LineAdjudicationInformationLoop222 { get; set; }
    // 2440 Loop
    [DataMember, WritableValue, PropertyClassification("Form Identification Code Loop", 280)]
    public FormIdentificationCodeLoop222[] FormIdentificationCodeLoop222 { get; set; }

    internal List<ReferringProviderNameLoop222> ReferringProviderNameLoop222ForDeserialize;
    internal List<LineAdjudicationInformationLoop222> LineAdjudicationInformationLoop222ForDeserialize;
    internal List<FormIdentificationCodeLoop222> FormIdentificationCodeLoop222ForDeserialize;

}