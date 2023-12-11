using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277;

[DataContract, Writable]
public class ReceiverLevelLoop364 // 2000B
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Receiver Name Loop", 20)]
    public PayerNameLoop364 ReceiverNameLoop364 { get; set; } // 2100B
    [DataMember, WritableValue, PropertyClassification("Receiver Trace Loop", 30)]
    public ReceiverTraceLoop364 ReceiverTraceLoop364 { get; set; } // 2200B
    [DataMember, WritableValue, PropertyClassification("Provider Level Loop", 40)]
    public ProviderLevelLoop364[] ProviderLevelLoop364 { get; set; } //Loop 2000C

    internal List<ProviderLevelLoop364> ProviderLevelLoop364ForDeserialize;
}