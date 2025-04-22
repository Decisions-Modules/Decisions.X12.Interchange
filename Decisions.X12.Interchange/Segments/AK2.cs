using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(AK2))]
[DataContract]
[Writable]
public class AK2
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Identifier Code", 10)]
    public string AK201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Control Number", 20)]
    public string AK202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Implementation Convention Reference", 30)]
    public string AK203 { get; set; }
}