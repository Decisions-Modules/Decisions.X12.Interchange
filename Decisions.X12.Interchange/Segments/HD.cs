using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class HD
{
    [DataMember, WritableValue, PropertyClassification("Maintenance Type Code", 10)]
    public string HD01 { get; set; }
}
