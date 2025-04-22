using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SVD))]
[DataContract]
[Writable]
public class SVD
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code", 10)]
    public string SVD01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string SVD02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 30)]
    public SVD03 SVD03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 40)]
    public string SVD04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 50)]
    public string SVD05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Number", 60)]
    public string SVD06 { get; set; }
}

[DataContract]
[Writable]
public class SVD03
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID Qualifier", 10)]
    public string SVD0301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 20)]
    public string SVD0302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SVD0303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SVD0304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SVD0305 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SVD0306 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SVD0307 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Service ID", 80)]
    public string SVD0308 { get; set; }
}