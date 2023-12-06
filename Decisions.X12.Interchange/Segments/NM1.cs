using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class NM1
{
    [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 10)]
    public string NM101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Entity Type Qualifier", 20)]
    public string NM102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name Last or Organization Name", 30)]
    public string NM103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name First", 40)]
    public string NM104 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name Middle", 50)]
    public string NM105 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name Prefix", 60)]
    public string NM106 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name Suffix", 70)]
    public string NM107 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code", 80)]
    public string NM108 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code Qualifier", 90)]
    public string NM109 { get; set; }
}
