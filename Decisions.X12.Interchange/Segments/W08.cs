using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W08))]
[DataContract]
[Writable]
public class W08
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Carrier Method/Type Code", 10)]
    public string W0801 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Standard Carrier Alpha Code", 20)]
    public string W0802 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Routing", 30)]
    public string W0803 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 40)]
    public string W0804 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Price/Rate Specification", 50)]
    public string W0805 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Carrier Organization Name", 60)]
    public string W0806 { get; set; }
}
