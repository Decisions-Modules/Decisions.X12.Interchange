using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class SubscriberHierarchicalLevelLoop222 // 2000B Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subscriber Information", 20)]
    public SBR SBR { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Information", 30)]
    public PAT PAT { get; set; }
    
    //2010BA Loop
    [DataMember, WritableValue, PropertyClassification("Subscriber Name Loop", 40)]
    public SubscriberNameLoop222 SubscriberNameLoop222 { get; set; }
    
    //2010BB Loop
    [DataMember, WritableValue, PropertyClassification("Payer Name Loop", 50)]
    public PayerNameLoop222 PayerNameLoop222 { get; set; }

    //2000C Loop
    [DataMember, WritableValue, PropertyClassification("Patient Hierarchical Loop", 60)]
    public PatientHierarchicalLoop222[] PatientHierarchicalLoop222 { get; set; }

    internal List<PatientHierarchicalLoop222> PatientHierarchicalLoop222ForDeserialize;
}