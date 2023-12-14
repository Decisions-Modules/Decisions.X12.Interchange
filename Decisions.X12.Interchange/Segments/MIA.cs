using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class MIA
{
    [DataMember, WritableValue, PropertyClassification("Quantity", 10)]
    public string MIA01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string MIA02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 30)]
    public string MIA03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 40)]
    public string MIA04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 50)]
    public string MIA05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 60)]
    public string MIA06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 70)]
    public string MIA07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string MIA08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 90)]
    public string MIA09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 100)]
    public string MIA10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 110)]
    public string MIA11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 120)]
    public string MIA12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 130)]
    public string MIA13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 140)]
    public string MIA14 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 150)]
    public string MIA15 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 160)]
    public string MIA16 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 170)]
    public string MIA17 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 180)]
    public string MIA18 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 190)]
    public string MIA19 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 200)]
    public string MIA20 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 210)]
    public string MIA21 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 220)]
    public string MIA22 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 230)]
    public string MIA23 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 240)]
    public string MIA24 { get; set; }
}