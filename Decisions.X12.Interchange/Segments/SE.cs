using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SE))]
[DataContract]
[Writable]
public class SE
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Included Segments", 10)]
    public string SE01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Control Number", 20)]
    public string SE02 { get; set; }
}