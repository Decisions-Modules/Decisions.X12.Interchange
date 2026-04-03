using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W12))]
[DataContract]
[Writable]
public class W12
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment/Order Status Code", 10)]
    public string W1201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Ordered", 20)]
    public string W1202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Units Shipped", 30)]
    public string W1203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 40)]
    public string W1204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 50)]
    public string W1205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("UPC Case Code", 60)]
    public string W1206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 70)]
    public string W1207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 80)]
    public string W1208 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Lot Number", 90)]
    public string W1209 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Qualifier", 100)]
    public string W1210 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier 2", 110)]
    public string W1211 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID 2", 120)]
    public string W1212 { get; set; }
}
