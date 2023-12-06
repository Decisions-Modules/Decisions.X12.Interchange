using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class RED
{
    [DataMember, WritableValue, PropertyClassification("Description", 10)]
    public string RED01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Related Data Identification Code", 20)]
    public string RED02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Agency Qualifier Code", 30)]
    public string RED03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Source Subqualifier", 40)]
    public string RED04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Code List Qualifier Code", 50)]
    public string RED05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Industry Code", 60)]
    public string RED06 { get; set; }
}