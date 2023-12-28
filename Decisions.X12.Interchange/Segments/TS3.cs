using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class TS3
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 10)]
    public string TS301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Facility Code Value", 20)]
    public string TS302 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 30)]
    public string TS303 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 40)]
    public string TS304 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 50)]
    public string TS305 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 60)]
    public string TS306 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 70)]
    public string TS307 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string TS308 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 90)]
    public string TS309 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 100)]
    public string TS310 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 110)]
    public string TS311 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 120)]
    public string TS312 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 130)]
    public string TS313 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 140)]
    public string TS314 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 150)]
    public string TS315 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 160)]
    public string TS316 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 170)]
    public string TS317 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 180)]
    public string TS318 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 190)]
    public string TS319 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 200)]
    public string TS320 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 210)]
    public string TS321 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 220)]
    public string TS322 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 230)]
    public string TS323 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 240)]
    public string TS324 { get; set; }
}