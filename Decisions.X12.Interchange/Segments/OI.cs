using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(OI))]
[DataContract]
[Writable]
public class OI
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Filing Indicator Code", 10)]
    public string OI01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Submission Reason Code", 20)]
    public string OI02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 30)]
    public string OI03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Signature Source Code", 40)]
    public string OI04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Agreement Code", 50)]
    public string OI05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Release of Information Code", 60)]
    public string OI06 { get; set; }
}