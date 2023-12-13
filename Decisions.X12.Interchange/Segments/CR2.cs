using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CR2
{
    [DataMember, WritableValue, PropertyClassification("Treatment Series Number", 10)]
    public string CR201 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Treatment Count", 20)]
    public string CR202 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subluxation Level Code", 30)]
    public string CR203 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subluxation Level Code", 40)]
    public string CR204 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 50)]
    public string CR205 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Treatment Time Period", 60)]
    public string CR206 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monthly Treatment Count", 70)]
    public string CR207 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Code", 80)]
    public string CR208 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 90)]
    public string CR209 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Condition Description", 100)]
    public string CR210 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Condition Description", 110)]
    public string CR211 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 120)]
    public string CR212 { get; set; }
    
}