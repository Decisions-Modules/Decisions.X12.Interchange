using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class FunctionalGroup834
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Header", 1)]
    public GS GS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction", 2)]
    public Transaction834 Transaction { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Trailer", 3)]
    public GE GE { get; set; }
}
