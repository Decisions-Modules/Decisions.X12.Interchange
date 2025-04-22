using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CL1))]
[DataContract]
[Writable]
public class CL1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Admission Type Code", 10)]
    public string CL101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Admission Source Code", 20)]
    public string CL102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Status Code", 30)]
    public string CL103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Nursing Home Residential Status Code", 40)]
    public string CL104 { get; set; }
}