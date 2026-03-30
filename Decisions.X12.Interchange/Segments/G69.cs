using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(G69))]
[DataContract]
[Writable]
public class G69
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Free-Form Description", 10)]
    public string G6901 { get; set; }
}
