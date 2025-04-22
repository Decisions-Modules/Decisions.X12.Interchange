using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(AK4))]
[DataContract]
[Writable]
public class AK4
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Position in Segment", 10)]
    public C030 AK401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Reference Code", 20)]
    public string AK402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Syntax Error Code", 30)]
    public string AK403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Copy of Bad Data Element", 40)]
    public string AK404 { get; set; }
}