using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class PAT
{
    [DataMember, WritableValue, PropertyClassification("Individual Relationship Code", 10)]
    public string PAT01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Location Code", 20)]
    public string PAT02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Employment Status Code", 30)]
    public string PAT03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Student Status Code", 40)]
    public string PAT04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period Format Qualifier", 50)]
    public string PAT05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period", 60)]
    public string PAT06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit or Basis for Measurement Code", 70)]
    public string PAT07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Weight", 80)]
    public string PAT08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Yes/No Condition", 90)]
    public string PAT09 { get; set; }
}