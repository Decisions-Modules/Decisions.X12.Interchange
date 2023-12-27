using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class PatientLevelLoop3642000D //2000D Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Name Loop", 20)]
    public PatientNameLoop3642100D PatientNameLoop3642100D { get; set; } // 2100D Loop
    [DataMember, WritableValue, PropertyClassification("Claim Level Tracking Number Loop", 30)]
    public ClaimStatusTrackingNumberLoop3642200D[] ClaimStatusTrackingNumberLoop3642200D { get; set; } // 2200D Loop

    internal List<ClaimStatusTrackingNumberLoop3642200D> ClaimStatusTrackingNumberLoop3642200DForDeserialize;
}