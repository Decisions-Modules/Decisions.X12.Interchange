using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(RED))]
[DataContract]
[Writable]
public class RED
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 10)]
    public string RED01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related Data Identification Code", 20)]
    public string RED02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Agency Qualifier Code", 30)]
    public string RED03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Source Subqualifier", 40)]
    public string RED04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 50)]
    public string RED05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 60)]
    public string RED06 { get; set; }
}