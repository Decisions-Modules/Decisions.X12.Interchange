using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class SponsorNameLoop
{
    [DataMember, WritableValue, PropertyClassification("Sponsor Name", 10)]
    public N1 N1 { get; set; }
}
