using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PO1))]
[DataContract]
[Writable]
public class PO1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Identification", 10)]
    public string PO101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Ordered", 20)]
    public string PO102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 30)]
    public string PO103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit Price", 40)]
    public string PO104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Basis of Unit Price Code", 50)]
    public string PO105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 60)]
    public string PO106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 70)]
    public string PO107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier 2", 80)]
    public string PO108 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID 2", 90)]
    public string PO109 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier 3", 100)]
    public string PO110 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID 3", 110)]
    public string PO111 { get; set; }
}
