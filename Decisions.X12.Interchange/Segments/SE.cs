using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12InterchangeTransaction;

[DataContract, Writable]
public class SE
{
    [DataMember, WritableValue, PropertyClassification("Number of Included Segments", 10)]
    public string SE01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Control Number", 20)]
    public string SE02 { get; set; }
}
