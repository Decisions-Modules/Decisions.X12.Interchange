using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class BGN
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Purpose Code", 10)]
    public string BGN01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string BGN02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 30)]
    public string BGN03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Time", 40)]
    public string BGN04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("BGN05", 50)]
    public string BGN05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("BGN06", 60)]
    public string BGN06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("BGN07", 70)]
    public string BGN07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Action Code", 80)]
    public string BGN08 { get; set; }
}
