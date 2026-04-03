using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W17))]
[DataContract]
[Writable]
public class W17
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Receipt Type Code", 10)]
    public string W1701 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 20)]
    public string W1702 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Receipt Number", 30)]
    public string W1703 { get; set; }
}
