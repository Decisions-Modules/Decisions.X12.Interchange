using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(REF))]
[DataContract]
[Writable]
public class REF
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 10)]
    public string REF01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string REF02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 30)]
    public string REF03 { get; set; }
}