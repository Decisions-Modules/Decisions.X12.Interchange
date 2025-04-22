using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(NTE))]
[DataContract]
[Writable]
public class NTE
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Note Reference Code", 10)]
    public string NTE01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 20)]
    public string NTE02 { get; set; }
}