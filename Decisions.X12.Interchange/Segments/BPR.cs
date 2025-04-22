using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(BPR))]
[DataContract]
[Writable]
public class BPR
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Handling Code", 10)]
    public string BPR01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string BPR02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Credit/Debit Flag Code", 30)]
    public string BPR03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payment Method Code", 40)]
    public string BPR04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payment Format Code", 50)]
    public string BPR05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("ID Number Qualifier", 60)]
    public string BPR06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Number", 70)]
    public string BPR07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number Qualifier", 80)]
    public string BPR08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number", 90)]
    public string BPR09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Originating Company Identifier", 100)]
    public string BPR10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Originating Company Supplemental Code", 110)]
    public string BPR11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("ID Number Qualifier", 120)]
    public string BPR12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Number", 130)]
    public string BPR13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number Qualifier", 140)]
    public string BPR14 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number", 150)]
    public string BPR15 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 160)]
    public string BPR16 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Business Function Code", 170)]
    public string BPR17 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("ID Number Qualifier", 180)]
    public string BPR18 { get; set; }

    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Number", 190)]
    public string BPR19 { get; set; }

    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number Qualifier", 200)]
    public string BPR20 { get; set; }

    [EdiElement(20)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Account Number", 210)]
    public string BPR21 { get; set; }
}