using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class MemberLevelDetailLoop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Level Detail", 10)]
    public INS INS { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subscriber or Member Number", 20)]
    public REF REF { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Name Loop", 30)]
    public MemberNameLoop MemberNameLoop { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Coverage Loop", 40)]
    public HealthCoverageLoop HealthCoverageLoop { get; set; }
}