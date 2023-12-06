using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class INS
{
    [DataMember, WritableValue, PropertyClassification("Insured Indicator", 10)]
    public string INS01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Individual Relationship Code", 20)]
    public string INS02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Maintenance Type Code", 30)]
    public string INS03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Maintenance Reason Code", 40)]
    public string INS04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Benefit Status Code", 50)]
    public string INS05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Medicare Plan Code", 60)]
    public string INS06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("COBRA Qualifying Event", 70)]
    public string INS07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Employment Status Code", 80)]
    public string INS08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Student Status", 90)]
    public string INS09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Handicap Indicator", 100)]
    public string INS10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Indicator", 110)]
    public string INS11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Death Date", 120)]
    public string INS12 { get; set; }
}
