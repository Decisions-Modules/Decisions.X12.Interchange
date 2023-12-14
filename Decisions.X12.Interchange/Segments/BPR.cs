using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class BPR
{
    [DataMember, WritableValue, PropertyClassification("Transaction Handling Code", 10)]
    public string BPR01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string BPR02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Credit/Debit Flag Code", 30)]
    public string BPR03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payment Method Code", 40)]
    public string BPR04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payment Format Code", 50)]
    public string BPR05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("ID Number Qualifier", 60)]
    public string BPR06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Number", 70)]
    public string BPR07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number Qualifier", 80)]
    public string BPR08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number", 90)]
    public string BPR09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Originating Company Identifier", 100)]
    public string BPR10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Originating Company Supplemental Code", 110)]
    public string BPR11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("ID Number Qualifier", 120)]
    public string BPR12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Number", 130)]
    public string BPR13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number Qualifier", 140)]
    public string BPR14 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number", 150)]
    public string BPR15 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 160)]
    public string BPR16 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Business Function Code", 170)]
    public string BPR17 { get; set; }
    [DataMember, WritableValue, PropertyClassification("ID Number Qualifier", 180)]
    public string BPR18 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Number", 190)]
    public string BPR19 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number Qualifier", 200)]
    public string BPR20 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Account Number", 210)]
    public string BPR21 { get; set; }
}