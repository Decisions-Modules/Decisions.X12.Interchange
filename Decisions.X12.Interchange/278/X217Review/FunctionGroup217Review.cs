using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class FunctionGroup217Review
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Header", 10)]
    public GS GS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction", 20)]
    public Transaction217Review Transaction { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Trailer", 30)]
    public GE GE { get; set; }
}