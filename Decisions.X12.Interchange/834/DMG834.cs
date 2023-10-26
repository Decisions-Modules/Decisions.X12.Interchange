using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class DMG834
{
    [DataMember, WritableValue, PropertyClassification("Date Time Format Qualifier", 10)]
    public string DMG01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period", 20)]
    public string DMG02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Gender Code", 30)]
    public string DMG03 { get; set; }
}
