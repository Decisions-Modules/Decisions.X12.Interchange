using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract]
[Writable]
public class PatientEventLevelLoop217Review2000E // 2000E
{
    internal List<PatientEventProviderLoop217Review2010EA> PatientEventProviderLoop217Review2010EAForDeserialize;
    internal List<ServiceLevelLoop217Review2000F> ServiceLevelLoop217Review2000FForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tracking Number", 20)]
    [XmlElement("TRN")]
    public TRN[] TRN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Services Review Information", 30)]
    public UM UM { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Secondary Information", 40)]
    public REF REF { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 50)]
    [XmlElement("DTP")]
    public DTP[] DTP { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Diagnosis", 60)]
    public HI HI { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Services Delivery", 70)]
    public HSD HSD { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Certification Information", 80)]
    [XmlElement("CRC")]
    public CRC[] CRC { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Institutional Claim Code", 90)]
    public CL1 CL1 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ambulance Transport Information", 100)]
    public CR1 CR1 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Spinal Manipulation Service Information", 110)]
    public CR2 CR2 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Home Oxygen Therapy Information", 120)]
    public CR5 CR5 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Home Oxygen Therapy Information", 130)]
    public CR6 CR6 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Patient Information", 140)]
    [XmlElement("PWK")]
    public PWK[] PWK { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Patient Information", 150)]
    public MSG MSG { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Event Provider Loop", 160)]
    public PatientEventProviderLoop217Review2010EA[] PatientEventProviderLoop217Review2010EA { get; set; } // 2010EA

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Level Loop", 170)]
    public ServiceLevelLoop217Review2000F[] ServiceLevelLoop217Review2000F { get; set; } // 2000F
}