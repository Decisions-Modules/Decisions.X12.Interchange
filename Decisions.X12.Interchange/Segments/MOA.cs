using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class MOA
{
    [DataMember, WritableValue, PropertyClassification("Percentage as Decimal", 10)]
    public string MOA01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string MOA02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string MOA03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 40)]
    public string MOA04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 50)]
    public string MOA05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 60)]
    public string MOA06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 70)]
    public string MOA07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string MOA08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 90)]
    public string MOA09 { get; set; }
}