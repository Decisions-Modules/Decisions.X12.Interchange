using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class SubscriberNameLoop217Review // 2010C
{
    [DataMember, WritableValue, PropertyClassification("Name", 10)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Supplemental Identification", 20)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address", 30)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("City, State, Zip Code", 40)]
    public N4 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Demographic Information", 50)]
    public DMG DMG { get; set; }
    [DataMember, WritableValue, PropertyClassification("Relationship", 60)]
    public INS INS { get; set; }
}