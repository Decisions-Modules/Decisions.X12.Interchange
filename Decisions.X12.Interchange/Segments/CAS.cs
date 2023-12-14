using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CAS
{
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Group Code", 10)]
    public string CAS01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 20)]
    public string CAS02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 30)]
    public string CAS03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 40)]
    public string CAS04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 50)]
    public string CAS05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 60)]
    public string CAS06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 70)]
    public string CAS07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 80)]
    public string CAS08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 90)]
    public string CAS09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 100)]
    public string CAS10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 110)]
    public string CAS11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 120)]
    public string CAS12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 130)]
    public string CAS13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 140)]
    public string CAS14 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 150)]
    public string CAS15 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 160)]
    public string CAS16 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment Reason Code", 170)]
    public string CAS17 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 180)]
    public string CAS18 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 190)]
    public string CAS19 { get; set; }
}