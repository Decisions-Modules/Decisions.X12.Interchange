using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(FRM))]
[DataContract]
[Writable]
public class FRM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Identification", 10)]
    public string FRM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 20)]
    public string FRM02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 30)]
    public string FRM03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 40)]
    public string FRM04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Percent, Decimal Format", 50)]
    public string FRM05 { get; set; }
}