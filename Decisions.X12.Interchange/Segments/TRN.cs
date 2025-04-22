using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TRN))]
[DataContract]
[Writable]
public class TRN
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Trace Type Code", 10)]
    public string TRN01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string TRN02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Originating Company Identifier", 30)]
    public string TRN03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 40)]
    public string TRN04 { get; set; }
}