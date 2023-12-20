using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class PS1
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 10)]
    public string PS101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string PS102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("State or Province Code", 30)]
    public string PS103 { get; set; }
}