using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class ISA834
{
    [DataMember, WritableValue, PropertyClassification("Interchange Control Header", 10)]
    public string ISA01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Authorization Information", 20)]
    public string ISA02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Security Information Qualifier", 30)]
    public string ISA03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Security Information", 40)]
    public string ISA04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange ID Qualifier (ISA05)", 50)]
    public string ISA05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Sender ID", 60)]
    public string ISA06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange ID Qualifier (ISA07)", 70)]
    public string ISA07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Receiver ID", 80)]
    public string ISA08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Date", 90)]
    public string ISA09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Time", 100)]
    public string ISA10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Standards Identifier", 110)]
    public string ISA11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Version Number", 120)]
    public string ISA12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Number", 130)]
    public string ISA13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Acknowledgment Requested", 140)]
    public string ISA14 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Usage Indicator", 150)]
    public string ISA15 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Component Element Separator", 160)]
    public string ISA16 { get; set; }
}
