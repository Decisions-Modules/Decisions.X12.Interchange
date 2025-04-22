using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CN1))]
[DataContract]
[Writable]
public class CN1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Type Code", 10)]
    public string CN101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Amount", 20)]
    public string CN102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Percentage", 30)]
    public string CN103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Code", 40)]
    public string CN104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Discount Percent", 50)]
    public string CN105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contract Version Identifier", 60)]
    public string CN106 { get; set; }
}