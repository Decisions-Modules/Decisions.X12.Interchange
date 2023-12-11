using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class HealthCoverageLoop
{
    [DataMember, WritableValue, PropertyClassification("Health Coverage", 10)]
    public HD HD { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Coverage Dates", 20)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Coverage Policy Number", 30)]
    public REF REF { get; set; }
}
