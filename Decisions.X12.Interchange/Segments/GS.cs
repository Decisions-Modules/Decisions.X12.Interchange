using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class GS
{
    [DataMember, WritableValue, PropertyClassification("Functional Identifier Code", 10)]
    public string GS01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Application Sender's Code", 20)]
    public string GS02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Application Receiver's Code", 30)]
    public string GS03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 40)]
    public string GS04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Time", 50)]
    public string GS05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Group Control Number", 60)]
    public string GS06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Responsible Agency Code", 70)]
    public string GS07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Version or Industry Identifier Code", 80)]
    public string GS08 { get; set; }
}
