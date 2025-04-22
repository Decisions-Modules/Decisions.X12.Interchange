using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract]
[Writable]
public class DependentLevelLoop217Review2000D // 2000D
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Dependent Name Loop", 20)]
    public DependentNameLoop217Review2010D DependentNameLoop217Review2010D { get; set; } // 2010D

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Event Loop", 30)]
    public PatientEventLevelLoop217Review2000E PatientEventLevelLoop217Review2000E { get; set; } // 2000E
}