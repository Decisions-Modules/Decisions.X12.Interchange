using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(N2))]
[DataContract]
[Writable]
public class N2
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name 1", 10)]
    public string N201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name 2", 20)]
    public string N202 { get; set; }
}