using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CR5))]
[DataContract]
[Writable]
public class CR5
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Certification Type Code", 10)]
    public string CR501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 20)]
    public string CR502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Equipment Type Code", 30)]
    public string CR503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Equipment Type Code", 40)]
    public string CR504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 50)]
    public string CR505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string CR506 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 70)]
    public string CR507 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 80)]
    public string CR508 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 90)]
    public string CR509 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 100)]
    public string CR510 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 110)]
    public string CR511 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Test Condition Code", 120)]
    public string CR512 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Test Findings Code", 130)]
    public string CR513 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Test Findings Code", 140)]
    public string CR514 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Test Findings Code", 150)]
    public string CR515 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 160)]
    public string CR516 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Delivery System Code", 170)]
    public string CR517 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oxygen Equipment Type Code", 180)]
    public string CR518 { get; set; }
}