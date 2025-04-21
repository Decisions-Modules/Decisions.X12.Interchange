using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK3
{
    [DataMember, WritableValue, PropertyClassification("Segment Identifier Code", 10)]
    public string AK301 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Segment Position in Transaction Set", 20)]
    public string AK302 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Loop Identifier Code", 30)]
    public string AK303 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Segment Syntax Error Code", 40)]
    public string AK304 { get; set; }
}