using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class SubscriberLevelLoop217Review // 2000C
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subscriber Name Loop", 20)]
    public SubscriberNameLoop217Review SubscriberNameLoop { get; set; } // 2010C
    [DataMember, WritableValue, PropertyClassification("Dependent Level Loop", 30)]
    public DependentLevelLoop217Review DependentLevelLoop { get; set; } // 2000D 
    [DataMember, WritableValue, PropertyClassification("Patient Event Loop", 40)]
    public PatientEventLevelLoop217Review PatientEventLevelLoop { get; set; } // 2000E
}