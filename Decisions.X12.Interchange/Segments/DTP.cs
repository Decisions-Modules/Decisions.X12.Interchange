using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(DTP))]
[DataContract]
[Writable]
public class DTP
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Qualifier", 10)]
    public string DTP01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Format Qualifier", 20)]
    public string DTP02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 30)]
    public string DTP03 { get; set; }
}