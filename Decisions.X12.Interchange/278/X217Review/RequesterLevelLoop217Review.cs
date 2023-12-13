using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class RequesterLevelLoop217Review // 2000B
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Requester Name Loop", 20)]
    public RequesterNameLoop217Review RequesterNameLoop { get; set; } // 2010B
    [DataMember, WritableValue, PropertyClassification("Subscriber Level Loop", 30)]
    public SubscriberLevelLoop217Review SubscriberLevelLoop { get; set; } // loop 2000C
}