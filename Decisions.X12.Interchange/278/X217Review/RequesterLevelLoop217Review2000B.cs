using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class RequesterLevelLoop217Review2000B // 2000B
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Requester Name Loop", 20)]
    public RequesterNameLoop217Review2010B RequesterNameLoop217Review2010B { get; set; } // 2010B
    [DataMember, WritableValue, PropertyClassification("Subscriber Level Loop", 30)]
    public SubscriberLevelLoop217Review2000C SubscriberLevelLoop217Review2000C { get; set; } // 2000C
}