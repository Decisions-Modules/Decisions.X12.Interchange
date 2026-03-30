using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(W20))]
[DataContract]
[Writable]
public class W20
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Qualifier", 10)]
    public string W2001 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight", 20)]
    public string W2002 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 30)]
    public string W2003 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Volume", 40)]
    public string W2004 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code 2", 50)]
    public string W2005 { get; set; }
}
