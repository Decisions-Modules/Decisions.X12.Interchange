using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CRC
{
    [DataMember, WritableValue, PropertyClassification("Code Category", 10)]
    public string CRC01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 20)]
    public string CRC02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Indicator", 30)]
    public string CRC03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Indicator", 40)]
    public string CRC04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Indicator", 50)]
    public string CRC05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Indicator", 60)]
    public string CRC06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Indicator", 70)]
    public string CRC07 { get; set; }
}