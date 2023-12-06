using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CTX
{
    [DataMember, WritableValue, PropertyClassification("Context Identification", 10)]
    public string CTX01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Segment ID Code", 20)]
    public string CTX02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Segment Position in Transaction Set", 30)]
    public string CTX03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Loop Identifier Code", 40)]
    public string CTX04 { get; set; }
}