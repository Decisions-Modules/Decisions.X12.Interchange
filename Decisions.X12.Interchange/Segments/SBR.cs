using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class SBR
{
    [DataMember, WritableValue, PropertyClassification("Payer Responsibility Sequence Number Code", 10)]
    public string SBR01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Individual Relationship Code", 20)]
    public string SBR02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string SBR03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name", 40)]
    public string SBR04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Insurance Type Code", 50)]
    public string SBR05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Coordination of Benefits Code", 60)]
    public string SBR06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 70)]
    public string SBR07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Employment Status Code", 80)]
    public string SBR08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Filing Indicator Code", 90)]
    public string SBR09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Source of Payment Typology Code", 100)]
    public string SBR10 { get; set; }
}