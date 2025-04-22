using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PER))]
[DataContract]
[Writable]
public class PER
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contact Function Code", 10)]
    public string PER01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 20)]
    public string PER02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Communication Number Qualifier", 30)]
    public string PER03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Communication Number", 40)]
    public string PER04 { get; set; }
}