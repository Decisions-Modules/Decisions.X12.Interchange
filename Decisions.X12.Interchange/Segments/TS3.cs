using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TS3))]
[DataContract]
[Writable]
public class TS3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 10)]
    public string TS301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Value", 20)]
    public string TS302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 30)]
    public string TS303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 40)]
    public string TS304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string TS305 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 60)]
    public string TS306 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 70)]
    public string TS307 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 80)]
    public string TS308 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 90)]
    public string TS309 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 100)]
    public string TS310 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 110)]
    public string TS311 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 120)]
    public string TS312 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 130)]
    public string TS313 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 140)]
    public string TS314 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 150)]
    public string TS315 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 160)]
    public string TS316 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 170)]
    public string TS317 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 180)]
    public string TS318 { get; set; }

    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 190)]
    public string TS319 { get; set; }

    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 200)]
    public string TS320 { get; set; }

    [EdiElement(20)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 210)]
    public string TS321 { get; set; }

    [EdiElement(21)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 220)]
    public string TS322 { get; set; }

    [EdiElement(22)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 230)]
    public string TS323 { get; set; }

    [EdiElement(23)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 240)]
    public string TS324 { get; set; }
}