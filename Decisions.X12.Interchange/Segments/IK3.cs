using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class IK3
{
    [DataMember, WritableValue, PropertyClassification("Segment ID Code", 10)]
    public string IK301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Segment Position in Transaction Set", 20)]
    public string IK302 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Loop Identifier Code", 30)]
    public string IK303 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Segment Syntax Error Code", 40)]
    public string IK304 { get; set; }
}