using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(ST))]
[DataContract]
[Writable]
public class ST
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Identifier Code", 10)]
    public string ST01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Control Number", 20)]
    public string ST02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Implementation Guide Version Name", 30)]
    public string ST03 { get; set; }
}