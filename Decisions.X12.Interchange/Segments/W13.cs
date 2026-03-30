using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W13))]
[DataContract]
[Writable]
public class W13
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 10)]
    public string W1301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 20)]
    public string W1302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Damage Reason Code", 30)]
    public string W1303 { get; set; }
}
