using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class UMONameLoop217Review
{
    [DataMember, WritableValue, PropertyClassification("Information Source Name", 10)]
    public NM1 NM1 { get; set; }
}