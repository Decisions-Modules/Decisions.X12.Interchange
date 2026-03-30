using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W66))]
[DataContract]
[Writable]
public class W66
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment Method of Payment", 10)]
    public string W6601 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Standard Carrier Alpha Code", 20)]
    public string W6602 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Terms Qualifier Code", 30)]
    public string W6603 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Terms Code", 40)]
    public string W6604 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Bill of Lading Liability Flag Code", 50)]
    public string W6605 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Lading Description", 60)]
    public string W6606 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Carrier Organization Name", 70)]
    public string W6607 { get; set; }
}
