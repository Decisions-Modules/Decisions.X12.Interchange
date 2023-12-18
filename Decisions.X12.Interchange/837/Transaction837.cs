using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class Transaction837
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Beginning of Hierarchical Transaction", 20)]
    public BHT BHT { get; set; }

    // 1000A loop
    [DataMember, WritableValue, PropertyClassification("Submitter Name Loop", 30)]
    public SubmitterNameLoop222 SubmitterNameLoop222 { get; set; }

    // 1000B loop
    [DataMember, WritableValue, PropertyClassification("Receiver Name Loop", 40)]
    public ReceiverNameLoop222 ReceiverNameLoop222 { get; set; }
    // 2000A loop
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 110)]
    public SE SE { get; set; }
}