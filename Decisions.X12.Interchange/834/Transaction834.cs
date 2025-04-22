using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class Transaction834
{
    internal List<MemberLevelDetailLoop> memberLevelDetailLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Beginning Segment", 20)]
    public BGN BGN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Policy Number", 30)]
    public REF REF { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Level Dates", 40)]
    public DTP DTP { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Sponsor Name Loop", 50)]
    public SponsorNameLoop SponsorNameLoop { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Level Detail Loop", 60)]
    public MemberLevelDetailLoop[] MemberLevelDetailLoop { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 70)]
    public SE SE { get; set; }
}