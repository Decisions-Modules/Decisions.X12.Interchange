using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class MSG
{
    [DataMember, WritableValue, PropertyClassification("Free-form Message Text", 10)]
    public string MSG01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Printer Carriage Control Code", 20)]
    public string MSG02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Number", 30)]
    public string MSG03 { get; set; }
}