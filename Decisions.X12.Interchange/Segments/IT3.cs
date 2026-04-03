using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(IT3))]
[DataContract]
[Writable]
public class IT3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Units Shipped", 10)]
    public string IT301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 20)]
    public string IT302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 30)]
    public string IT303 { get; set; }
}
