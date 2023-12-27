using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ReceiverLevelLoop3642000B // 2000B
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Receiver Name Loop", 20)]
    public ReceiverNameLoop3642100B ReceiverNameLoop3642100B { get; set; } // 2100B
    [DataMember, WritableValue, PropertyClassification("Receiver Trace Loop", 30)]
    public ReceiverTraceLoop3642200B ReceiverTraceLoop3642200B { get; set; } // 2200B
    [DataMember, WritableValue, PropertyClassification("Provider Level Loop", 40)]
    public ProviderLevelLoop3642000C[] ProviderLevelLoop3642000C { get; set; } //Loop 2000C

    internal List<ProviderLevelLoop3642000C> ProviderLevelLoop3642000CForDeserialize;
}