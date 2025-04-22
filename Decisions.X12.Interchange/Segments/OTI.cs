using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(OTI))]
[DataContract]
[Writable]
public class OTI
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Application Acknowledgment Code", 10)]
    public string OTI01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification Qualifier", 20)]
    public string OTI02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 30)]
    public string OTI03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Application Sender's Code", 40)]
    public string OTI04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Application Receiver's Code", 50)]
    public string OTI05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 60)]
    public string OTI06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Time", 60)]
    public string OTI07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Group Control Number", 70)]
    public string OTI08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Control Number", 80)]
    public string OTI09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Identifier Code", 90)]
    public string OTI10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version / Release / Industry Identifier Code", 100)]
    public string OTI11 { get; set; }
}