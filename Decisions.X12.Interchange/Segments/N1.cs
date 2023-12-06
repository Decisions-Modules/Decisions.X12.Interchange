using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class N1
{
    [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 10)]
    public string N101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name", 20)]
    public string N102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code Qualifier", 30)]
    public string N103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code", 40)]
    public string N104 { get; set; }
}
