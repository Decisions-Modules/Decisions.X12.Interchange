using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(BIG))]
[DataContract]
[Writable]
public class BIG
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 10)]
    public string BIG01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Invoice Number", 20)]
    public string BIG02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 30)]
    public string BIG03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchase Order Number", 40)]
    public string BIG04 { get; set; }
}
