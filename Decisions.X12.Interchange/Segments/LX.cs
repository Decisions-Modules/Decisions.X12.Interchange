using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class LX
{
    [DataMember, WritableValue, PropertyClassification("Assigned Number", 10)]
    public string LX01 { get; set; }
}