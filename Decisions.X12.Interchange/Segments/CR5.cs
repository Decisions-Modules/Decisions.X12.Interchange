using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CR5
{
    [DataMember, WritableValue, PropertyClassification("Certification Type Code", 10)]
    public string CR501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 20)]
    public string CR502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Equipment Type Code", 30)]
    public string CR503 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Equipment Type Code", 40)]
    public string CR504 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 50)]
    public string CR505 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 60)]
    public string CR506 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 70)]
    public string CR507 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 80)]
    public string CR508 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 90)]
    public string CR509 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 100)]
    public string CR510 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 110)]
    public string CR511 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Test Condition Code", 120)]
    public string CR512 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Test Findings Code", 130)]
    public string CR513 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Test Findings Code", 140)]
    public string CR514 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Test Findings Code", 150)]
    public string CR515 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 160)]
    public string CR516 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Delivery System Code", 170)]
    public string CR517 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Equipment Type Code", 180)]
    public string CR518 { get; set; }
}