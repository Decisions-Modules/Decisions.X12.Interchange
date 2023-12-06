using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class AMT
{
    [DataMember, WritableValue, PropertyClassification("Amount Qualifier Code", 10)]
    public string AMT01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string AMT02 { get; set; }
}