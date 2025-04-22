using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CLP))]
[DataContract]
[Writable]
public class CLP
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Submitter's Identifier", 10)]
    public string CLP01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Status Code", 20)]
    public string CLP02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 30)]
    public string CLP03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 40)]
    public string CLP04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string CLP05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Filing Indicator Code", 60)]
    public string CLP06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 70)]
    public string CLP07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Value", 80)]
    public string CLP08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Frequency Type Code", 90)]
    public string CLP09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Status Code", 100)]
    public string CLP10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Diagnosis Related Group (DRG) Code", 110)]
    public string CLP11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 120)]
    public string CLP12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Percentage as Decimal", 130)]
    public string CLP13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 140)]
    public string CLP14 { get; set; }
}