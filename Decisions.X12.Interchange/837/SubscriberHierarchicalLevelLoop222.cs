using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class SubscriberHierarchicalLevelLoop222 // 2000B Loop
{
    internal List<ClaimInformationLoop222> ClaimInformationLoopForDeserialize;

    internal List<PatientHierarchicalLoop222> PatientHierarchicalLoop222ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subscriber Information", 20)]
    public SBR SBR { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Information", 30)]
    public PAT PAT { get; set; }

    //2010BA Loop
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subscriber Name Loop", 40)]
    public SubscriberNameLoop222 SubscriberNameLoop222 { get; set; }

    //2010BB Loop
    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payer Name Loop", 50)]
    public PayerNameLoop222 PayerNameLoop222 { get; set; }

    // 2300 Loop
    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Information Loop", 60)]
    public ClaimInformationLoop222[] ClaimInformationLoop222 { get; set; }

    //2000C Loop
    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Hierarchical Loop", 70)]
    public PatientHierarchicalLoop222[] PatientHierarchicalLoop222 { get; set; }
}