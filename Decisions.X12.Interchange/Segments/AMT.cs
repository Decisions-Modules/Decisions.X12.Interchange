using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(AMT))]
[DataContract]
[Writable]
public class AMT
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount Qualifier Code", 10)]
    public string AMT01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string AMT02 { get; set; }
}