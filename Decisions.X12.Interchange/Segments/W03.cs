using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W03))]
[DataContract]
[Writable]
public class W03
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Units Shipped", 10)]
    public string W0301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Gross Weight", 20)]
    public string W0302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 30)]
    public string W0303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Pallet Block", 40)]
    public string W0304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Pallet Basis", 50)]
    public string W0305 { get; set; }
}
