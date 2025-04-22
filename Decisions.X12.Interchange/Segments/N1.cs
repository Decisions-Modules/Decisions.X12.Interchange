using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(N1))]
[DataContract]
[Writable]
public class N1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 10)]
    public string N101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 20)]
    public string N102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code Qualifier", 30)]
    public string N103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code", 40)]
    public string N104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Relationship Code", 50)]
    public string N105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 50)]
    public string N106 { get; set; }
}