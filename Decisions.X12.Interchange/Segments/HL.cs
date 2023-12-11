using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class HL
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical ID Number", 10)]
    public string HL01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Hierarchical Parent ID Number", 20)]
    public string HL02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level Code", 30)]
    public string HL03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Hierarchical Child Code", 40)]
    public string HL04 { get; set; }
}