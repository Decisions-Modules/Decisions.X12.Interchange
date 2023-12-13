using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class UM
{
    [DataMember, WritableValue, PropertyClassification("Request Category Code", 10)]
    public string UM01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Certification Type Code", 20)]
    public string UM02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Type Code", 30)]
    public string UM03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Service Location Information", 40)]
    public UM04 UM04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Related Causes Information", 50)]
    public UM05 UM05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Level of Service Code", 60)]
    public string UM06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Current Health Condition Code", 70)]
    public string UM07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Prognosis Code", 80)]
    public string UM08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Release of Information Code", 90)]
    public string UM09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Delay Reason Code", 100)]
    public string UM10 { get; set; }
    
}

[DataContract, Writable]
public class UM04
{
    [DataMember, WritableValue, PropertyClassification("Facility Code Value", 10)]
    public string UM0401 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Facility Code Qualifier", 20)]
    public string UM0402 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Frequency Type Code", 30)]
    public string UM0403 { get; set; }
}

[DataContract, Writable]
public class UM05
{
    [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 10)]
    public string UM0501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 20)]
    public string UM0502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 30)]
    public string UM0503 { get; set; }
    [DataMember, WritableValue, PropertyClassification("State or Province Code", 40)]
    public string UM0504 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Country Code", 50)]
    public string UM0505 { get; set; }
}