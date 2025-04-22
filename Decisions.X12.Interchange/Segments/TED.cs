using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TED))]
[DataContract]
[Writable]
public class TED
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Application Error Condition Code", 10)]
    public string TED01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Free-form Message", 20)]
    public string TED02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Segment ID Code", 30)]
    public string TED03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Segment Position in Transaction Set", 40)]
    public string TED04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Position in Segment", 50)]
    public string TED05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference in Segment", 60)]
    public string TED06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Copy of Bad Data Element", 70)]
    public string TED07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element New Content", 80)]
    public string TED08 { get; set; }
}