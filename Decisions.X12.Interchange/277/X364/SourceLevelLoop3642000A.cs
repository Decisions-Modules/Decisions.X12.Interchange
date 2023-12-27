using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class SourceLevelLoop3642000A // 2000A
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payer Name Loop", 20)]
    public PayerNameLoop3642100A PayerNameLoop3642100A { get; set; } // 2100A
    [DataMember, WritableValue, PropertyClassification("Claim Submitter Trace Number Loop", 30)]
    public ClaimSubmitterTraceNumberLoop3642200A ClaimSubmitterTraceNumberLoop3642200A { get; set; } // 2200A
    [DataMember, WritableValue, PropertyClassification("Information Receiver Level Hierarchical Loop", 40)]
    public ReceiverLevelLoop3642000B ReceiverLevelLoop3642000B { get; set; } // 2000B
}