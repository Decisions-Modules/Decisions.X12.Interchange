using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TD3))]
[DataContract]
[Writable]
public class TD3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Description Code", 10)]
    public string TD301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Initial", 20)]
    public string TD302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Equipment Number", 30)]
    public string TD303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Seal Number", 40)]
    public string TD304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Seal Number 2", 50)]
    public string TD305 { get; set; }
}
