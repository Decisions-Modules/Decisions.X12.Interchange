using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class PatientHierarchicalLoop222 // 2000C Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Information", 20)]
    public PAT PAT { get; set; }
    
    // 2010CA Loop
    [DataMember, WritableValue, PropertyClassification("Patient Name Loop", 30)]
    public PatientNameLoop222 PatientNameLoop222 { get; set; }
    
    // 2300 Loop
    [DataMember, WritableValue, PropertyClassification("Claim Information Loop", 40)]
    public ClaimInformationLoop222[] ClaimInformationLoop { get; set; }
    
    internal List<ClaimInformationLoop222> ClaimInformationLoopForDeserialize;
}