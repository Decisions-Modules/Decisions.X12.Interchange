using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CR1))]
[DataContract]
[Writable]
public class CR1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 10)]
    public string CR101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 20)]
    public string CR102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Transport Code", 30)]
    public string CR103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Transport Reason Code", 40)]
    public string CR104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 50)]
    public string CR105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string CR106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address Information", 70)]
    public string CR107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address Information", 80)]
    public string CR108 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Round Trip Purpose Description", 90)]
    public string CR109 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Stretcher Purpose Description", 100)]
    public string CR110 { get; set; }
}