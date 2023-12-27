using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class ServiceLevelLoop217Review2000F // 2000F
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Tracking Number", 20)]
    [XmlElement("TRN")]
    public TRN[] TRN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Review Information", 30)]
    public UM UM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Authorization Number", 40)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Date", 50)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Professional Service", 60)]
    public SV1 SV1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Institutional Service Line", 70)]
    public SV2 SV2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Diagnosis", 80)]
    public SV3 SV3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Tooth Information", 90)]
    [XmlElement("TOO")]
    public TOO[] TOO { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Delivery", 100)]
    public HSD HSD { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Service Information", 110)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }
    [DataMember, WritableValue, PropertyClassification("Message Text", 120)]
    public MSG MSG { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Provider Name Loop", 130)]
    public ServiceProviderLoop217Review2010F[] ServiceProviderLoop217Review2010F { get; set; } // 2010F

    internal List<ServiceProviderLoop217Review2010F> ServiceProviderLoop217Review2010FForDeserialize;
}