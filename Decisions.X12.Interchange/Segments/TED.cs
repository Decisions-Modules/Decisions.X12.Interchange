using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class TED
{
    [DataMember, WritableValue, PropertyClassification("Application Error Condition Code", 10)]
    public string TED01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Free-form Message", 20)]
    public string TED02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Segment ID Code", 30)]
    public string TED03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Segment Position in Transaction Set", 40)]
    public string TED04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Position in Segment", 50)]
    public string TED05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference in Segment", 60)]
    public string TED06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Copy of Bad Data Element", 70)]
    public string TED07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Data Element New Content", 80)]
    public string TED08 { get; set; }
}