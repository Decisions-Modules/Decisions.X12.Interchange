using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CR6
{
    [DataMember, WritableValue, PropertyClassification("Prognosis Code", 10)]
    public string CR601 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 20)]
    public string CR602 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string CR603 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period", 40)]
    public string CR604 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 50)]
    public string CR605 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 60)]
    public string CR606 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 70)]
    public string CR607 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Certification Type Code", 80)]
    public string CR608 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Surgery Date", 90)]
    public string CR609 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service ID Qualifier", 100)]
    public string CR610 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Medical Code Code", 110)]
    public string CR611 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 120)]
    public string CR612 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 130)]
    public string CR613 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 140)]
    public string CR614 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period Format Qualifier", 150)]
    public string CR615 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date Time Period", 160)]
    public string CR616 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Location Code", 170)]
    public string CR617 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 180)]
    public string CR618 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 190)]
    public string CR619 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 200)]
    public string CR620 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 210)]
    public string CR621 { get; set; }
}