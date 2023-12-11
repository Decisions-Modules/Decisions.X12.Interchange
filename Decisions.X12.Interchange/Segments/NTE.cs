using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class NTE
{
    [DataMember, WritableValue, PropertyClassification("Note Reference Code", 10)]
    public string NTE01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 20)]
    public string NTE02 { get; set; }
}