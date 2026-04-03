using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(G62))]
[DataContract]
[Writable]
public class G62
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Qualifier", 10)]
    public string G6201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 20)]
    public string G6202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Time Qualifier", 30)]
    public string G6203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Time", 40)]
    public string G6204 { get; set; }
}
