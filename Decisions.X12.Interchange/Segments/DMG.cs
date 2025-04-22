using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(DMG))]
[DataContract]
[Writable]
public class DMG
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Format Qualifier", 10)]
    public string DMG01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 20)]
    public string DMG02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Gender Code", 30)]
    public string DMG03 { get; set; }
}