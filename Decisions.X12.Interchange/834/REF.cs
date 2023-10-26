using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class REF
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 10)]
    public string REF01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string REF02 { get; set; }
}
