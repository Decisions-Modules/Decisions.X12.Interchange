using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(INS))]
[DataContract]
[Writable]
public class INS
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Insured Indicator", 10)]
    public string INS01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Individual Relationship Code", 20)]
    public string INS02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Maintenance Type Code", 30)]
    public string INS03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Maintenance Reason Code", 40)]
    public string INS04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Benefit Status Code", 50)]
    public string INS05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Medicare Plan Code", 60)]
    public string INS06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("COBRA Qualifying Event", 70)]
    public string INS07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Employment Status Code", 80)]
    public string INS08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Student Status", 90)]
    public string INS09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Handicap Indicator", 100)]
    public string INS10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Indicator", 110)]
    public string INS11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Death Date", 120)]
    public string INS12 { get; set; }
}