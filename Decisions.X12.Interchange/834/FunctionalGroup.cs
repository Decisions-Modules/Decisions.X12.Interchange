using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class FunctionalGroup
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Header", 1)]
    public GS834 GS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction", 2)]
    public Transaction Transaction { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Trailer", 3)]
    public GE834 GE { get; set; }
}
