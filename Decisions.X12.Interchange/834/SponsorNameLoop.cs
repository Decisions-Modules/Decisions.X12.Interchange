using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class SponsorNameLoop
{
    [DataMember, WritableValue, PropertyClassification("Sponsor Name", 10)]
    public N1834 N1 { get; set; }
}
