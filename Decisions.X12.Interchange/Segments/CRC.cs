using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CRC))]
[DataContract]
[Writable]
public class CRC
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code Category", 10)]
    public string CRC01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 20)]
    public string CRC02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Indicator", 30)]
    public string CRC03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Indicator", 40)]
    public string CRC04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Indicator", 50)]
    public string CRC05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Indicator", 60)]
    public string CRC06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Indicator", 70)]
    public string CRC07 { get; set; }
}