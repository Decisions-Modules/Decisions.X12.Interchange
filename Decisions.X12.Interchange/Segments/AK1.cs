using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK1
{
    [DataMember, WritableValue, PropertyClassification("Functional Identifier Code", 10)]
    public string AK101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Group Control Number", 20)]
    public string AK102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Version / Release / Industry Identifier Code", 30)]
    public string AK103 { get; set; }
}