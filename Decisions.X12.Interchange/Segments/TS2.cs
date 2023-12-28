using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class TS2
{
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 10)]
    public string TS201 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string TS202 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 30)]
    public string TS203 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 40)]
    public string TS204 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 50)]
    public string TS205 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 60)]
    public string TS206 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 70)]
    public string TS207 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string TS208 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 90)]
    public string TS209 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 100)]
    public string TS210 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 110)]
    public string TS211 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 120)]
    public string TS212 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 130)]
    public string TS213 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 140)]
    public string TS214 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 150)]
    public string TS215 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 160)]
    public string TS216 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 170)]
    public string TS217 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 180)]
    public string TS218 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 190)]
    public string TS219 { get; set; }
}