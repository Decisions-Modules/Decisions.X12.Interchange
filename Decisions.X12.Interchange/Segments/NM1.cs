using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(NM1))]
[DataContract]
[Writable]
public class NM1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 10)]
    public string NM101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Type Qualifier", 20)]
    public string NM102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name Last or Organization Name", 30)]
    public string NM103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name First", 40)]
    public string NM104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name Middle", 50)]
    public string NM105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name Prefix", 60)]
    public string NM106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name Suffix", 70)]
    public string NM107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code", 80)]
    public string NM108 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code Qualifier", 90)]
    public string NM109 { get; set; }
}