using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class Transaction222
{
    internal List<BillingProviderHierarchicalLevelLoop222> BillingProviderHierarchicalLevelLoop222ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Beginning of Hierarchical Transaction", 20)]
    public BHT BHT { get; set; }

    // 1000A loop
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Submitter Name Loop", 30)]
    public SubmitterNameLoop222 SubmitterNameLoop222 { get; set; }

    // 1000B loop
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Receiver Name Loop", 40)]
    public ReceiverNameLoop222 ReceiverNameLoop222 { get; set; }

    // 2000A loop
    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Billing Provider Hierarchical Loop", 50)]
    public BillingProviderHierarchicalLevelLoop222[] BillingProviderHierarchicalLevelLoop222 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 60)]
    public SE SE { get; set; }
}