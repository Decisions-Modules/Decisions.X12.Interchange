using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class HD
{
    [DataMember, WritableValue, PropertyClassification("Maintenance Type Code", 10)]
    public string HD01 { get; set; }
}
