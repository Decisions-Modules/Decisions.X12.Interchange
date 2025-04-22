using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(GE))]
[DataContract]
[Writable]
public class GE
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Transaction Sets Included", 10)]
    public string GE01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Group Control Number", 20)]
    public string GE02 { get; set; }
}