using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class DependentLevelLoop217Review // 2000D
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Dependent Name Loop", 20)]
    public DependentNameLoop217Review DependentNameLoop { get; set; } // 2010D
    [DataMember, WritableValue, PropertyClassification("Patient Event Loop", 30)]
    public PatientEventLevelLoop217Review PatientEventLevelLoop { get; set; } // 2000E
}