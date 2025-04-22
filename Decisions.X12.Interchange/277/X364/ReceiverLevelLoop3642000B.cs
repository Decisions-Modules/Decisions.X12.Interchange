using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract]
[Writable]
public class ReceiverLevelLoop3642000B // 2000B
{
    internal List<ProviderLevelLoop3642000C> ProviderLevelLoop3642000CForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Receiver Name Loop", 20)]
    public ReceiverNameLoop3642100B ReceiverNameLoop3642100B { get; set; } // 2100B

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Receiver Trace Loop", 30)]
    public ReceiverTraceLoop3642200B ReceiverTraceLoop3642200B { get; set; } // 2200B

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Level Loop", 40)]
    public ProviderLevelLoop3642000C[] ProviderLevelLoop3642000C { get; set; } //Loop 2000C
}