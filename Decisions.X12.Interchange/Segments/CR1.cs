using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CR1
{
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 10)]
    public string CR101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Weight", 20)]
    public string CR102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Transport Code", 30)]
    public string CR103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Transport Reason Code", 40)]
    public string CR104 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 50)]
    public string CR105 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 60)]
    public string CR106 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address Information", 70)]
    public string CR107 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address Information", 80)]
    public string CR108 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Round Trip Purpose Description", 90)]
    public string CR109 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Stretcher Purpose Description", 100)]
    public string CR110 { get; set; }
}