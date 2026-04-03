using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CAD))]
[DataContract]
[Writable]
public class CAD
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Method/Type Code", 10)]
    public string CAD01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Initial", 20)]
    public string CAD02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Number", 30)]
    public string CAD03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Standard Carrier Alpha Code", 40)]
    public string CAD04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Routing", 50)]
    public string CAD05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 60)]
    public string CAD06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 70)]
    public string CAD07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 80)]
    public string CAD08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Level Code", 90)]
    public string CAD09 { get; set; }
}
