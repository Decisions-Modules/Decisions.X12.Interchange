using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class PatientHierarchicalLoop222 // 2000C Loop
{
    internal List<ClaimInformationLoop222> ClaimInformationLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Information", 20)]
    public PAT PAT { get; set; }

    // 2010CA Loop
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Name Loop", 30)]
    public PatientNameLoop222 PatientNameLoop222 { get; set; }

    // 2300 Loop
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Information Loop", 40)]
    public ClaimInformationLoop222[] ClaimInformationLoop222 { get; set; }
}