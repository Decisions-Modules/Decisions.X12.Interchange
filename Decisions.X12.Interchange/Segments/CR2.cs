using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CR2))]
[DataContract]
[Writable]
public class CR2
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Treatment Series Number", 10)]
    public string CR201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Treatment Count", 20)]
    public string CR202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subluxation Level Code", 30)]
    public string CR203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subluxation Level Code", 40)]
    public string CR204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 50)]
    public string CR205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Treatment Time Period", 60)]
    public string CR206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monthly Treatment Count", 70)]
    public string CR207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Code", 80)]
    public string CR208 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string CR209 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Condition Description", 100)]
    public string CR210 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Condition Description", 110)]
    public string CR211 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 120)]
    public string CR212 { get; set; }
}