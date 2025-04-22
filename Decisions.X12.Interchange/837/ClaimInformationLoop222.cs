using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class ClaimInformationLoop222 // 2300 Loop
{
    internal List<OtherSubscriberInformationLoop222> OtherSubscriberInformationLoop222ForDeserialize;

    internal List<ReferringProviderNameLoop222> ReferringProviderNameLoop222ForDeserialize;
    internal List<ServiceLineNumberLoop222> ServiceLineNumberLoop222ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Information", 10)]
    public CLM CLM { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Dates", 20)]
    [XmlElement("DTP")]
    public DTP[] DTP { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Codes", 30)]
    public CL1 CL1 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Supplemental Information", 40)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Information", 50)]
    public CN1 CN1 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Amount Paid", 60)]
    public AMT AMT { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Information", 70)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("File Information", 80)]
    [XmlElement("K3")]
    public K3[] K3 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Note", 90)]
    public NTE NTE { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Transport Information", 100)]
    public CR1 CR1 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Spinal Manipulation Service Information", 110)]
    public CR2 CR2 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Conditions Indicator", 120)]
    [XmlElement("CRC")]
    public CRC[] CRC { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Diagnosis", 130)]
    [XmlElement("HI")]
    public HI[] HI { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Pricing/Repricing Information", 140)]
    public HCP HCP { get; set; }

    // 2310A Loop
    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Referring Provider Name Loop", 150)]
    public ReferringProviderNameLoop222[] ReferringProviderNameLoop222 { get; set; }

    // 2310B Loop
    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Rendering Provider Name Loop", 160)]
    public RenderingProviderNameLoop222 RenderingProviderNameLoop222 { get; set; }

    // 2310C Loop
    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Facility Location Name Loop", 170)]
    public ServiceFacilityLocationNameLoop222 ServiceFacilityLocationNameLoop222 { get; set; }

    // 2310D Loop
    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Supervising Provider Name Loop", 180)]
    public SupervisingProviderNameLoop222 SupervisingProviderNameLoop222 { get; set; }

    // 2310E Loop
    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Pickup Location Loop", 190)]
    public AmbulancePickupLocationLoop222 AmbulancePickupLocationLoop222 { get; set; }

    // 2310F Loop
    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Dropoff Location Loop", 200)]
    public AmbulanceDropoffLocationLoop222 AmbulanceDropoffLocationLoop222 { get; set; }

    // 2320 Loop
    [EdiElement(20)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Subscriber Information Loop", 210)]
    public OtherSubscriberInformationLoop222[] OtherSubscriberInformationLoop222 { get; set; }

    // 2400 Loop
    [EdiElement(21)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Line Number Loop", 220)]
    public ServiceLineNumberLoop222[] ServiceLineNumberLoop222 { get; set; }
}