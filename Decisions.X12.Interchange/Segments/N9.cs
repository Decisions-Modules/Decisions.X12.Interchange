using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(N9))]
[DataContract]
[Writable]
public class N9
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 10)]
    public string N901 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string N902 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Free-Form Description", 30)]
    public string N903 { get; set; }
}
