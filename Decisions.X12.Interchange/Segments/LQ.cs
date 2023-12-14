using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class LQ
{
    [DataMember, WritableValue, PropertyClassification("Code List Qualifier Code", 10)]
    public string LQ01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Industry Code", 20)]
    public string LQ02 { get; set; }
}