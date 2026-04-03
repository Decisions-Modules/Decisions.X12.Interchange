using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TD5))]
[DataContract]
[Writable]
public class TD5
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Routing Sequence Code", 10)]
    public string TD501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code Qualifier", 20)]
    public string TD502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code", 30)]
    public string TD503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Method/Type Code", 40)]
    public string TD504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Routing", 50)]
    public string TD505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 60)]
    public string TD506 { get; set; }
}
