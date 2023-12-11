using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277;

[DataContract, Writable]
public class PatientLevelLoop364 //2000D Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Name Loop", 20)]
    public PayerNameLoop364 PatientNameLoop { get; set; } // 2100D Loop
    [DataMember, WritableValue, PropertyClassification("Claim Level Tracking Number Loop", 20)]
    public ClaimLevelTrackingNumberLoop364[] ClaimLevelTrackingNumberLoop { get; set; } //2200D

    internal List<ClaimLevelTrackingNumberLoop364> ClaimLevelStatusInformationLoop364ForDeserialize;
}