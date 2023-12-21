using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK2
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Identifier Code", 10)]
    public string AK201 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Control Number", 20)]
    public string AK202 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Convention Reference", 30)]
    public string AK203 { get; set; }
}