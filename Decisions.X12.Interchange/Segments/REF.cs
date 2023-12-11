using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class REF
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 10)]
    public string REF01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string REF02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 30)]
    public string REF03 { get; set; }
}
