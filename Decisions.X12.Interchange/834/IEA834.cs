using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class IEA834
{
    [DataMember, WritableValue, PropertyClassification("Number of Included Functional Groups", 10)]
    public string IEA01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Number", 20)]
    public string IEA02 { get; set; }
}
