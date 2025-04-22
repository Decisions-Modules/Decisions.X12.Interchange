using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(N3))]
[DataContract]
[Writable]
public class N3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address Line 1", 10)]
    public string N301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address Line 2", 20)]
    public string N302 { get; set; }
}