using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class LM
{
    [DataMember, WritableValue, PropertyClassification("Agency Qualifier Code", 10)]
    public string LM01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Source Subqualifier", 20)]
    public string LM02 { get; set; }
}