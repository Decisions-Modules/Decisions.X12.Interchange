using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(N4))]
[DataContract]
[Writable]
public class N4
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("City", 10)]
    public string N401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("State", 20)]
    public string N402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Postal Code", 30)]
    public string N403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Country Code", 40)]
    public string N404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Location Qualifier", 50)]
    public string N405 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Location Identifier", 60)]
    public string N406 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Country Subdivision Code", 70)]
    public string N407 { get; set; }
}