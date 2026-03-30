using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PRF))]
[DataContract]
[Writable]
public class PRF
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchase Order Number", 10)]
    public string PRF01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Release Number", 20)]
    public string PRF02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Change Order Sequence Number", 30)]
    public string PRF03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchase Order Date", 40)]
    public string PRF04 { get; set; }
}
