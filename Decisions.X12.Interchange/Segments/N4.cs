using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class N4
{
    [DataMember, WritableValue, PropertyClassification("City", 10)]
    public string N401 { get; set; }
    [DataMember, WritableValue, PropertyClassification("State", 20)]
    public string N402 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Postal Code", 30)]
    public string N403 { get; set; }
}
