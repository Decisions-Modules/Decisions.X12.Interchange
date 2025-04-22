using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(C030))]
[DataContract]
[Writable]
public class C030
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Element Position in Segment", 10)]
    public string C03001 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Component Data Element Position in Composite", 20)]
    public string C03002 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Repeating Data Element Position", 30)]
    public string C03003 { get; set; }
}