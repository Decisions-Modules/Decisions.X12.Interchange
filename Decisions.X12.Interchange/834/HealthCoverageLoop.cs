using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class HealthCoverageLoop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Coverage", 10)]
    public HD HD { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Coverage Dates", 20)]
    public DTP DTP { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Coverage Policy Number", 30)]
    public REF REF { get; set; }
}