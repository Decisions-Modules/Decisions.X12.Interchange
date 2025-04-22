using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CAS))]
[DataContract]
[Writable]
public class CAS
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Group Code", 10)]
    public string CAS01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 20)]
    public string CAS02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 30)]
    public string CAS03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 40)]
    public string CAS04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 50)]
    public string CAS05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 60)]
    public string CAS06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 70)]
    public string CAS07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 80)]
    public string CAS08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 90)]
    public string CAS09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 100)]
    public string CAS10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 110)]
    public string CAS11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 120)]
    public string CAS12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 130)]
    public string CAS13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 140)]
    public string CAS14 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 150)]
    public string CAS15 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 160)]
    public string CAS16 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment Reason Code", 170)]
    public string CAS17 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 180)]
    public string CAS18 { get; set; }

    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 190)]
    public string CAS19 { get; set; }
}