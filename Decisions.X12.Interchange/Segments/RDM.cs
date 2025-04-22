using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(RDM))]
[DataContract]
[Writable]
public class RDM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Transmission Code", 10)]
    public string RDM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 20)]
    public string RDM02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Communication Number", 30)]
    public string RDM03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identifier", 40)]
    public RDM04 RDM04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identifier", 50)]
    public RDM05 RDM05 { get; set; }
}

[DataContract]
[Writable]
public class RDM04
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 10)]
    public string RDM0401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string RDM0402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 30)]
    public string RDM0403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 40)]
    public string RDM0404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 50)]
    public string RDM0405 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 60)]
    public string RDM0406 { get; set; }
}

[DataContract]
[Writable]
public class RDM05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 10)]
    public string RDM0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string RDM0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 30)]
    public string RDM0503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 40)]
    public string RDM0504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 50)]
    public string RDM0505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 60)]
    public string RDM0506 { get; set; }
}