using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(QTY))]
[DataContract]
[Writable]
public class QTY
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Qualifier", 10)]
    public string QTY01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 20)]
    public string QTY02 { get; set; }
}