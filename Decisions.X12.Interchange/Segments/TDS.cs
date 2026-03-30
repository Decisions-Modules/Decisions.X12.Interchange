using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TDS))]
[DataContract]
[Writable]
public class TDS
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount", 10)]
    public string TDS01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount (Term Discount)", 20)]
    public string TDS02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount (Discounted)", 30)]
    public string TDS03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount (Due)", 40)]
    public string TDS04 { get; set; }
}
