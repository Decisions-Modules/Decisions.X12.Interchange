using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W06))]
[DataContract]
[Writable]
public class W06
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reporting Code", 10)]
    public string W0601 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Depositor Order Number", 20)]
    public string W0602 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 30)]
    public string W0603 { get; set; }
}
