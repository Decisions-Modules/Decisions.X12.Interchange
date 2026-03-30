using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TC2))]
[DataContract]
[Writable]
public class TC2
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Commodity Code Qualifier", 10)]
    public string TC201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Commodity Code", 20)]
    public string TC202 { get; set; }
}
