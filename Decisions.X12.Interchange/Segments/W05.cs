using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W05))]
[DataContract]
[Writable]
public class W05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Order Status Code", 10)]
    public string W0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Depositor Order Number", 20)]
    public string W0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchase Order Number", 30)]
    public string W0503 { get; set; }
}
