using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class Transaction834
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Beginning Segment", 20)]
    public BGN BGN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Policy Number", 30)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Level Dates", 40)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Sponsor Name Loop", 50)]
    public SponsorNameLoop SponsorNameLoop { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Level Detail Loop", 60)]
    public MemberLevelDetailLoop[] MemberLevelDetailLoop { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 70)]
    public SE SE { get; set; }
    
    internal List<MemberLevelDetailLoop> memberLevelDetailLoopForDeserialize;
}
