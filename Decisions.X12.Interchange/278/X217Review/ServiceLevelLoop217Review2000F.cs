using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract]
[Writable]
public class ServiceLevelLoop217Review2000F // 2000F
{
    internal List<ServiceProviderLoop217Review2010F> ServiceProviderLoop217Review2010FForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tracking Number", 20)]
    [XmlElement("TRN")]
    public TRN[] TRN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Services Review Information", 30)]
    public UM UM { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Authorization Number", 40)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Date", 50)]
    public DTP DTP { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Professional Service", 60)]
    public SV1 SV1 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Institutional Service Line", 70)]
    public SV2 SV2 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Diagnosis", 80)]
    public SV3 SV3 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Information", 90)]
    [XmlElement("TOO")]
    public TOO[] TOO { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Services Delivery", 100)]
    public HSD HSD { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Service Information", 110)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Message Text", 120)]
    public MSG MSG { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Provider Name Loop", 130)]
    public ServiceProviderLoop217Review2010F[] ServiceProviderLoop217Review2010F { get; set; } // 2010F
}