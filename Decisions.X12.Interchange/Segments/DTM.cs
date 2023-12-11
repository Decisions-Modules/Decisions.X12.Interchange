using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class DTM
{
    [DataMember, WritableValue, PropertyClassification("DateTime Qualifier", 10)]
    public string DTM01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 20)]
    public string DTM02 { get; set; }
}