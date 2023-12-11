using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class GE
{
    [DataMember, WritableValue, PropertyClassification("Number of Transaction Sets Included", 10)]
    public string GE01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Group Control Number", 20)]
    public string GE02 { get; set; }
}
