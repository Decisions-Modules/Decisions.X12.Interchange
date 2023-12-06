using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class N2
{
    [DataMember, WritableValue, PropertyClassification("Name 1", 10)]
    public string N201 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name 2", 20)]
    public string N202 { get; set; }
}