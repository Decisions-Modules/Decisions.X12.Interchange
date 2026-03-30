using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W07))]
[DataContract]
[Writable]
public class W07
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Received", 10)]
    public string W0701 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 20)]
    public string W0702 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Qualifier", 30)]
    public string W0703 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 40)]
    public string W0704 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 50)]
    public string W0705 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier 2", 60)]
    public string W0706 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID 2", 70)]
    public string W0707 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Lot Number", 80)]
    public string W0708 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 90)]
    public string W0709 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code 2", 100)]
    public string W0710 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Lot Type Code", 110)]
    public string W0711 { get; set; }
}
