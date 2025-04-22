using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class ServiceLineNumberLoop222 // 2400 Loop
{
    internal List<FormIdentificationCodeLoop222> FormIdentificationCodeLoop222ForDeserialize;
    internal List<LineAdjudicationInformationLoop222> LineAdjudicationInformationLoop222ForDeserialize;

    internal List<ReferringProviderNameLoop222> ReferringProviderNameLoop222ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Line Number", 10)]
    public LX LX { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Professional Service", 20)]
    public SV1 SV1 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Institutional Service", 30)]
    public SV2 SV2 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Line Number", 40)]
    public SV5 SV5 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Supplemental Information", 50)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Transport Information", 60)]
    public CR1 CR1 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Durable Medical Equipment Certification", 70)]
    public CR3 CR3 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Conditions Indicators", 80)]
    [XmlElement("CRC")]
    public CRC[] CRC { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Dates", 90)]
    [XmlElement("DTP")]
    public DTP[] DTP { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantities", 100)]
    [XmlElement("QTY")]
    public QTY[] QTY { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Test Results", 110)]
    [XmlElement("MEA")]
    public MEA[] MEA { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Information", 120)]
    public CN1 CN1 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Numbers", 130)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amounts", 140)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("File Information", 150)]
    [XmlElement("K3")]
    public K3[] K3 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Notes", 160)]
    [XmlElement("NTE")]
    public NTE[] NTE { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchased Service Information", 170)]
    public PS1 PS1 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Pricing/Repricing Information", 180)]
    public HCP HCP { get; set; }

    // 2410 Loop
    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Drug Identification Loop", 190)]
    public DrugIdentificationLoop222 DrugIdentificationLoop222 { get; set; }

    // 2420A Loop
    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Rendering Provider Name Loop", 200)]
    public RenderingProviderNameLoop222 RenderingProviderNameLoop222 { get; set; }

    // 2420B Loop
    [EdiElement(20)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchased Service Provider Name Loop", 210)]
    public PurchasedServiceProviderNameLoop222 PurchasedServiceProviderNameLoop222 { get; set; }

    // 2420C Loop
    [EdiElement(21)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Facility Location Name Loop", 220)]
    public ServiceFacilityLocationNameLoop222 ServiceFacilityLocationNameLoop222 { get; set; }

    // 2420D Loop
    [EdiElement(22)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Supervising Provider Name Loop", 230)]
    public SupervisingProviderNameLoop222 SupervisingProviderNameLoop222 { get; set; }

    // 2420E Loop
    [EdiElement(23)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ordering Provider Name Loop", 240)]
    public OrderingProviderNameLoop222 OrderingProviderNameLoop222 { get; set; }

    // 2420F Loop
    [EdiElement(24)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Referring Provider Name Loop", 250)]
    public ReferringProviderNameLoop222[] ReferringProviderNameLoop222 { get; set; }

    // 2420G Loop
    [EdiElement(25)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Pickup Location Loop", 260)]
    public AmbulancePickupLocationLoop222 AmbulancePickupLocationLoop222 { get; set; }

    // 2420H Loop
    [EdiElement(26)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Dropoff Location Loop", 270)]
    public AmbulanceDropoffLocationLoop222 AmbulanceDropoffLocationLoop222 { get; set; }

    // 2430 Loop
    [EdiElement(27)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Adjudication Information Loop", 280)]
    public LineAdjudicationInformationLoop222[] LineAdjudicationInformationLoop222 { get; set; }

    // 2440 Loop
    [EdiElement(28)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Form Identification Code Loop", 290)]
    public FormIdentificationCodeLoop222[] FormIdentificationCodeLoop222 { get; set; }
}