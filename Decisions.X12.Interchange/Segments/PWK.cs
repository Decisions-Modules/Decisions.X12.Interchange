using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class PWK
{
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 10)]
    public string PWK01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Transmission Code", 20)]
    public string PWK02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Copies Needed", 30)]
    public string PWK03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 40)]
    public string PWK04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code Qualifier", 50)]
    public string PWK05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Identification Code", 60)]
    public string PWK06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 70)]
    public string PWK07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Actions Indicated", 80)]
    public PWK08 PWK08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Request Category Code", 90)]
    public string PWK09 { get; set; }
}

[DataContract, Writable]
public class PWK08
{
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 10)]
    public string PWK0801 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 20)]
    public string PWK0802 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 30)]
    public string PWK0803 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 40)]
    public string PWK0804 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Report Type Code", 50)]
    public string PWK0805 { get; set; }
}