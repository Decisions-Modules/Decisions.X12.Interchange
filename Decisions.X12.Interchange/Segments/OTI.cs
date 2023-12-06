using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class OTI
{
    [DataMember, WritableValue, PropertyClassification("Application Acknowledgment Code", 10)]
    public string OTI01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 20)]
    public string OTI02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string OTI03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Application Sender's Code", 40)]
    public string OTI04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Application Receiver's Code", 50)]
    public string OTI05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 60)]
    public string OTI06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Time", 60)]
    public string OTI07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Group Control Number", 70)]
    public string OTI08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Control Number", 80)]
    public string OTI09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Identifier Code", 90)]
    public string OTI10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Version / Release / Industry Identifier Code", 100)]
    public string OTI11 { get; set; }
    
}