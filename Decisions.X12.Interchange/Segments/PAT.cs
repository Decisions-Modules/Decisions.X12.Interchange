using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PAT))]
[DataContract]
[Writable]
public class PAT
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Individual Relationship Code", 10)]
    public string PAT01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Location Code", 20)]
    public string PAT02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Employment Status Code", 30)]
    public string PAT03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Student Status Code", 40)]
    public string PAT04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 50)]
    public string PAT05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 60)]
    public string PAT06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit or Basis for Measurement Code", 70)]
    public string PAT07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 80)]
    public string PAT08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition", 90)]
    public string PAT09 { get; set; }
}