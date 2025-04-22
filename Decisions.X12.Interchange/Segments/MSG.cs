using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(MSG))]
[DataContract]
[Writable]
public class MSG
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Free-form Message Text", 10)]
    public string MSG01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Printer Carriage Control Code", 20)]
    public string MSG02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number", 30)]
    public string MSG03 { get; set; }
}