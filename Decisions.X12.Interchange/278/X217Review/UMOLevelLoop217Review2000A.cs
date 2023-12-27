using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class UMOLevelLoop217Review2000A // 2000A
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("UMO Name Loop", 20)]
    public UMONameLoop217Review2010A UMONameLoop217Review2010A { get; set; } // 2010A
    [DataMember, WritableValue, PropertyClassification("Requester Level Loop", 30)]
    public RequesterLevelLoop217Review2000B RequesterLevelLoop217Review2000B { get; set; } // 2000B
}