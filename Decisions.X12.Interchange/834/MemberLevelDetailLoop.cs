using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class MemberLevelDetailLoop
{
    [DataMember, WritableValue, PropertyClassification("Member Level Detail", 10)]
    public INS INS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subscriber or Member Number", 20)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Name Loop", 30)]
    public MemberNameLoop MemberNameLoop { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Coverage Loop", 40)]
    public HealthCoverageLoop HealthCoverageLoop { get; set; }
}
