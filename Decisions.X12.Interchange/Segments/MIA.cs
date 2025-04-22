using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(MIA))]
[DataContract]
[Writable]
public class MIA
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 10)]
    public string MIA01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string MIA02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 30)]
    public string MIA03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 40)]
    public string MIA04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 50)]
    public string MIA05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 60)]
    public string MIA06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 70)]
    public string MIA07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 80)]
    public string MIA08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 90)]
    public string MIA09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 100)]
    public string MIA10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 110)]
    public string MIA11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 120)]
    public string MIA12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 130)]
    public string MIA13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 140)]
    public string MIA14 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 150)]
    public string MIA15 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 160)]
    public string MIA16 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 170)]
    public string MIA17 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 180)]
    public string MIA18 { get; set; }

    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 190)]
    public string MIA19 { get; set; }

    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 200)]
    public string MIA20 { get; set; }

    [EdiElement(20)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 210)]
    public string MIA21 { get; set; }

    [EdiElement(21)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 220)]
    public string MIA22 { get; set; }

    [EdiElement(22)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 230)]
    public string MIA23 { get; set; }

    [EdiElement(23)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 240)]
    public string MIA24 { get; set; }
}