using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class DTP
{
    [DataMember, WritableValue, PropertyClassification("Date Time Qualifier", 10)]
    public string DTP01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Format Qualifier", 20)]
    public string DTP02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period", 30)]
    public string DTP03 { get; set; }
}
