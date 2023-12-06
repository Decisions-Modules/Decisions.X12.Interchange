using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class N3
{
    [DataMember, WritableValue, PropertyClassification("Address Line 1", 10)]
    public string N301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address Line 2", 20)]
    public string N302 { get; set; }
}
