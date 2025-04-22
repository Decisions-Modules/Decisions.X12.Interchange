using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(HSD))]
[DataContract]
[Writable]
public class HSD
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Qualifier", 10)]
    public string HSD01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 20)]
    public string HSD02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 30)]
    public string HSD03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Sample Selection Modulus", 40)]
    public string HSD04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Time Period Qualifier", 50)]
    public string HSD05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Periods", 60)]
    public string HSD06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Calendar Pattern Code", 70)]
    public string HSD07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Delivery Pattern Time Code", 80)]
    public string HSD08 { get; set; }
}