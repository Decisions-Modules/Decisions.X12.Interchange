using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class ST
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Identifier Code", 10)]
    public string ST01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Control Number", 20)]
    public string ST02 { get; set; }
}
