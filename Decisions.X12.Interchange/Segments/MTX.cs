using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(MTX))]
[DataContract]
[Writable]
public class MTX
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Record Type", 10)]
    public string MTX01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 20)]
    public string MTX02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 30)]
    public string MTX03 { get; set; }
}
