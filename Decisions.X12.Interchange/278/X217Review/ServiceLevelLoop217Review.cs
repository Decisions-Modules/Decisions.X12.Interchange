using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class ServiceLevelLoop217Review // 2000F
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    [XmlElement("HL", Order = 1)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Tracking Number", 20)]
    [XmlElement("TRN", Order = 2)]
    public TRN[] TRN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Review Information", 30)]
    [XmlElement("UM", Order = 3)]
    public UM UM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Authorization Number", 40)]
    [XmlElement("REF", Order = 4)]
    public REF REFAuthorizationNumber { get; set; }
    [DataMember, WritableValue, PropertyClassification("Previous Review Administrative Reference Number", 50)]
    [XmlElement("REF", Order = 5)]
    public REF REFNumber { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Date", 60)]
    [XmlElement("DTP", Order = 6)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Professional Service", 70)]
    [XmlElement("SV1", Order = 7)]
    public SV1 SV1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Institutional Service Line", 80)]
    [XmlElement("SV2", Order = 8)]
    public SV2 SV2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Diagnosis", 90)]
    [XmlElement("SV3", Order = 9)]
    public SV3 SV3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Tooth Information", 100)]
    [XmlElement("TOO", Order = 10)]
    public TOO TOO { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Delivery", 110)]
    [XmlElement("HSD", Order = 11)]
    public HSD HSD { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Service Information", 120)]
    [XmlElement("PWK", Order = 12)]
    public PWK PWK { get; set; }
    [DataMember, WritableValue, PropertyClassification("Message Text", 130)]
    [XmlElement("MSG", Order = 13)]
    public MSG MSG { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Provider Name Loop", 140)]
    [XmlElement("Loop", Order = 14)]
    public ServiceProviderLoop217Review[] ServiceProviderLoop { get; set; } // 2010F
}