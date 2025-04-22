using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(ISA))]
[DataContract]
[Writable]
public class ISA
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Header", 10)]
    public string ISA01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Authorization Information", 20)]
    public string ISA02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Security Information Qualifier", 30)]
    public string ISA03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Security Information", 40)]
    public string ISA04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange ID Qualifier", 50)]
    public string ISA05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Sender ID", 60)]
    public string ISA06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange ID Qualifier", 70)]
    public string ISA07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Receiver ID", 80)]
    public string ISA08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Date", 90)]
    public string ISA09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Time", 100)]
    public string ISA10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Standards Identifier", 110)]
    public string ISA11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Version Number", 120)]
    public string ISA12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Number", 130)]
    public string ISA13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Acknowledgment Requested", 140)]
    public string ISA14 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Usage Indicator", 150)]
    public string ISA15 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Component Element Separator", 160)]
    public string ISA16 { get; set; }
}