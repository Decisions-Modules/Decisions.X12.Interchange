using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W27))]
[DataContract]
[Writable]
public class W27
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Method/Type Code", 10)]
    public string W2701 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Standard Carrier Alpha Code", 20)]
    public string W2702 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Routing", 30)]
    public string W2703 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 40)]
    public string W2704 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Initial", 50)]
    public string W2705 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Number", 60)]
    public string W2706 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Description Code", 70)]
    public string W2707 { get; set; }
}
