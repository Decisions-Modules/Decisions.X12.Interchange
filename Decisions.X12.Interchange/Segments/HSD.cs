using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class HSD
{
    [DataMember, WritableValue, PropertyClassification("Quantity Qualifier", 10)]
    public string HSD01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 20)]
    public string HSD02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 30)]
    public string HSD03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Sample Selection Modulus", 40)]
    public string HSD04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Time Period Qualifier", 50)]
    public string HSD05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Number of Periods", 60)]
    public string HSD06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Calendar Pattern Code", 70)]
    public string HSD07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Delivery Pattern Time Code", 80)]
    public string HSD08 { get; set; }
}