using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class LIN
{
    [DataMember, WritableValue, PropertyClassification("Assigned Identification", 10)]
    public string LIN01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 20)]
    public string LIN02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 30)]
    public string LIN03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 40)]
    public string LIN04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 50)]
    public string LIN05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 60)]
    public string LIN06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 70)]
    public string LIN07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 80)]
    public string LIN08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 90)]
    public string LIN09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 100)]
    public string LIN10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 110)]
    public string LIN11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 120)]
    public string LIN12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 130)]
    public string LIN13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 140)]
    public string LIN14 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 150)]
    public string LIN15 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 160)]
    public string LIN16 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 170)]
    public string LIN17 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 180)]
    public string LIN18 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 190)]
    public string LIN19 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 200)]
    public string LIN20 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 210)]
    public string LIN21 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 220)]
    public string LIN22 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 230)]
    public string LIN23 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 240)]
    public string LIN24 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 250)]
    public string LIN25 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 260)]
    public string LIN26 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 270)]
    public string LIN27 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 280)]
    public string LIN28 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 290)]
    public string LIN29 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 300)]
    public string LIN30 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 310)]
    public string LIN31 { get; set; }

}