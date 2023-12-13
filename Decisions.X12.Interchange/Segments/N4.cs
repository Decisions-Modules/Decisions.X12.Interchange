using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class N4
{
    [DataMember, WritableValue, PropertyClassification("City", 10)]
    public string N401 { get; set; }
    [DataMember, WritableValue, PropertyClassification("State", 20)]
    public string N402 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Postal Code", 30)]
    public string N403 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Country Code", 40)]
    public string N404 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Location Qualifier", 50)]
    public string N405 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Location Identifier", 60)]
    public string N406 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Country Subdivision Code", 70)]
    public string N407 { get; set; }
}
