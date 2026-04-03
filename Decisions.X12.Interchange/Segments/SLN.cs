using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SLN))]
[DataContract]
[Writable]
public class SLN
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Identification", 10)]
    public string SLN01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Sub-Line Item Number", 20)]
    public string SLN02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Relationship Code", 30)]
    public string SLN03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 40)]
    public string SLN04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 50)]
    public string SLN05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit Price", 60)]
    public string SLN06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Basis of Unit Price Code", 70)]
    public string SLN07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 80)]
    public string SLN08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 90)]
    public string SLN09 { get; set; }
}
