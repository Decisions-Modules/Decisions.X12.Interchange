using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CTT))]
[DataContract]
[Writable]
public class CTT
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Line Items", 10)]
    public string CTT01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hash Total", 20)]
    public string CTT02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 30)]
    public string CTT03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 40)]
    public string CTT04 { get; set; }
}
