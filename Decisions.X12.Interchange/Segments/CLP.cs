using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CLP
{
    [DataMember, WritableValue, PropertyClassification("Claim Submitter's Identifier", 10)]
    public string CLP01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Status Code", 20)]
    public string CLP02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 30)]
    public string CLP03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 40)]
    public string CLP04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 50)]
    public string CLP05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Filing Indicator Code", 60)]
    public string CLP06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 70)]
    public string CLP07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Facility Code Value", 80)]
    public string CLP08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Frequency Type Code", 90)]
    public string CLP09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Status Code", 100)]
    public string CLP10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Diagnosis Related Group (DRG) Code", 110)]
    public string CLP11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 120)]
    public string CLP12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Percentage as Decimal", 130)]
    public string CLP13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 140)]
    public string CLP14 { get; set; }
}