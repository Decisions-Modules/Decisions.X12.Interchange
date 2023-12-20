using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class ClaimInformationLoop222 // 2300 Loop
{
    [DataMember, WritableValue, PropertyClassification("Claim Information", 10)]
    public CLM CLM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Dates", 20)]
    [XmlElement("DTP")]
    public DTP[] DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Supplemental Information", 30)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }
    [DataMember, WritableValue, PropertyClassification("Contract Information", 40)]
    public CN1 CN1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Amount Paid", 50)]
    public AMT AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Information", 60)]
    [XmlElement("REF")]
    public List<REF> REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("File Information", 70)]
    [XmlElement("K3")]
    public K3[] K3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Note", 80)]
    public NTE NTE { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Transport Information", 90)]
    public CR1 CR1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Spinal Manipulation Service Information", 100)]
    public CR2 CR2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Conditions Indicator", 110)]
    [XmlElement("CRC")]
    public CRC[] CRC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Diagnosis", 120)]
    [XmlElement("HI")]
    public HI[] HI { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Pricing/Repricing Information", 130)]
    public HCP HCP { get; set; }
    
    // 2310A Loop
    [DataMember, WritableValue, PropertyClassification("Referring Provider Name Loop", 140)]
    public ReferringProviderNameLoop222[] ReferringProviderNameLoop222 { get; set; }
    // 2310B Loop
    [DataMember, WritableValue, PropertyClassification("Rendering Provider Name Loop", 150)]
    public RenderingProviderNameLoop222 RenderingProviderNameLoop222 { get; set; }
    // 2310C Loop
    [DataMember, WritableValue, PropertyClassification("Service Facility Location Name Loop", 160)]
    public ServiceFacilityLocationNameLoop222 ServiceFacilityLocationNameLoop222 { get; set; }
    // 2310D Loop
    [DataMember, WritableValue, PropertyClassification("Supervising Provider Name Loop", 170)]
    public SupervisingProviderNameLoop222 SupervisingProviderNameLoop222 { get; set; }
    // 2310E Loop
    [DataMember, WritableValue, PropertyClassification("Ambulance Pickup Location Loop", 180)]
    public AmbulancePickupLocationLoop222 AmbulancePickupLocationLoop222 { get; set; }
    // 2310F Loop
    [DataMember, WritableValue, PropertyClassification("Ambulance Dropoff Location Loop", 190)]
    public AmbulanceDropoffLocationLoop222 AmbulanceDropoffLocationLoop222 { get; set; }
    // 2320 Loop
    [DataMember, WritableValue, PropertyClassification("Other Subscriber Information Loop", 200)]
    public OtherSubscriberInformationLoop222[] OtherSubscriberInformationLoop222 { get; set; }
    // 2400 Loop
    [DataMember, WritableValue, PropertyClassification("Service Line Number Loop", 210)]
    public ServiceLineNumberLoop222[] ServiceLineNumberLoop222 { get; set; }

    internal List<ReferringProviderNameLoop222> ReferringProviderNameLoop222ForDeserialize;
    internal List<OtherSubscriberInformationLoop222> OtherSubscriberInformationLoop222ForDeserialize;
    internal List<ServiceLineNumberLoop222> ServiceLineNumberLoop222ForDeserialize;
}