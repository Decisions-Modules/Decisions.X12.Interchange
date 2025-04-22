using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract]
[Writable]
public class RequesterLevelLoop217Review2000B // 2000B
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Requester Name Loop", 20)]
    public RequesterNameLoop217Review2010B RequesterNameLoop217Review2010B { get; set; } // 2010B

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subscriber Level Loop", 30)]
    public SubscriberLevelLoop217Review2000C SubscriberLevelLoop217Review2000C { get; set; } // 2000C
}