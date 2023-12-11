using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

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
    [DataMember, WritableValue, PropertyClassification("Entity Relationship Code", 50)]
    public string N105 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 50)]
    public string N106 { get; set; }
}
