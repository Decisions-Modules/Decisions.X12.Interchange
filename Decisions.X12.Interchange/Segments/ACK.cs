using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(ACK))]
[DataContract]
[Writable]
public class ACK
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Item Status Code", 10)]
    public string ACK01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 20)]
    public string ACK02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 30)]
    public string ACK03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date/Time Qualifier", 40)]
    public string ACK04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 50)]
    public string ACK05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 60)]
    public string ACK06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 70)]
    public string ACK07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier 2", 80)]
    public string ACK08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID 2", 90)]
    public string ACK09 { get; set; }
}
