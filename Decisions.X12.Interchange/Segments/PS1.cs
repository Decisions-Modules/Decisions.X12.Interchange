using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PS1))]
[DataContract]
[Writable]
public class PS1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 10)]
    public string PS101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string PS102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("State or Province Code", 30)]
    public string PS103 { get; set; }
}