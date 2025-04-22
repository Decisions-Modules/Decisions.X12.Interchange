using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TA1))]
[DataContract]
[Writable]
public class TA1 : EdiSegmentBase
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Number", 10)]
    public string TA101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Date", 20)]
    public string TA102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Time", 30)]
    public string TA103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Acknowledgement Code", 40)]
    public string TA104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Note Code", 50)]
    public string TA105 { get; set; }
}