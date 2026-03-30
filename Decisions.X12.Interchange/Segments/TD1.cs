using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TD1))]
[DataContract]
[Writable]
public class TD1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Packaging Code", 10)]
    public string TD101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Lading Quantity", 20)]
    public string TD102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Commodity Code Qualifier", 30)]
    public string TD103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Commodity Code", 40)]
    public string TD104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Qualifier", 50)]
    public string TD105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Gross Weight", 60)]
    public string TD106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 70)]
    public string TD107 { get; set; }
}
