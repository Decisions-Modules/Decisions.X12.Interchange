using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange278X217Review;

[DataContract, Writable]
public class PatientEventLevelLoop217Review // 2000E
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    [XmlElement("HL", Order = 1)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Tracking Number", 20)]
    [XmlElement("TRN", Order = 2)]
    public TRN[] TRN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Review Information", 30)]
    [XmlElement("UM", Order = 3)]
    public UM UM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Previous Review Administrative Reference Number", 40)]
    [XmlElement("REF", Order = 4)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Accident Date", 50)]
    [XmlElement("DTP", Order = 5)]
    public DTP DTPAccidentDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Last Menstrual Date", 60)]
    [XmlElement("DTP", Order = 6)]
    public DTP DTPLastMenstrualDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Estimated Date of Birth", 70)]
    [XmlElement("DTP", Order = 7)]
    public DTP DTPEstDateOfBirth { get; set; }
    [DataMember, WritableValue, PropertyClassification("Illness Date", 80)]
    [XmlElement("DTP", Order = 8)]
    public DTP DTPIllnessDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Event Date", 90)]
    [XmlElement("DTP", Order = 9)]
    public DTP DTPEventDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Admission Date", 100)]
    [XmlElement("DTP", Order = 10)]
    public DTP DTPAdmissionDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Discharge Date", 110)]
    [XmlElement("DTP", Order = 11)]
    public DTP DTPDischargeDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Diagnosis", 120)]
    [XmlElement("HI", Order = 12)]
    public HI HI { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Services Delivery", 130)]
    [XmlElement("HSD", Order = 13)]
    public HSD HSD { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Certification Information", 140)]
    [XmlElement("CRC", Order = 14)]
    public CRC CRCAmbulance { get; set; }
    [DataMember, WritableValue, PropertyClassification("Chiropractic Certification Information", 150)]
    [XmlElement("CRC", Order = 15)]
    public CRC CRCChiropractic { get; set; }
    [DataMember, WritableValue, PropertyClassification("Medical Equipment Information", 160)]
    [XmlElement("CRC", Order = 16)]
    public CRC CRCEquipment { get; set; }
    [DataMember, WritableValue, PropertyClassification("Oxygen Therapy Certification Information", 170)]
    [XmlElement("CRC", Order = 17)]
    public CRC CRCTherapy { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Limitations Information", 180)]
    [XmlElement("CRC", Order = 18)]
    public CRC CRCLimitations { get; set; }
    [DataMember, WritableValue, PropertyClassification("Activities Permitted Information", 190)]
    [XmlElement("CRC", Order = 19)]
    public CRC CRCActivities { get; set; }
    [DataMember, WritableValue, PropertyClassification("Mental Status Information", 200)]
    [XmlElement("CRC", Order = 20)]
    public CRC CRCStatus { get; set; }
    [DataMember, WritableValue, PropertyClassification("Institutional Claim Code", 210)]
    [XmlElement("CL1", Order = 21)]
    public CL1 CL1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Ambulance Transport Information", 220)]
    [XmlElement("CR1", Order = 22)]
    public CR1 CR1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Spinal Manipulation Service Information", 230)]
    [XmlElement("CR2", Order = 23)]
    public CR2 CR2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Home Oxygen Therapy Information", 240)]
    [XmlElement("CR5", Order = 24)]
    public CR5 CR5 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Home Oxygen Therapy Information", 250)]
    [XmlElement("CR6", Order = 25)]
    public CR6 CR6 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Patient Information", 260)]
    [XmlElement("PWK", Order = 26)]
    public PWK PWK { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Patient Information", 270)]
    [XmlElement("MSG", Order = 27)]
    public MSG MSG { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Event Provider Loop", 280)]
    [XmlElement("Loop", Order = 28)]
    public PatientEventProviderLoop217Review[] PatientEventProviderLoop { get; set; } // 2010EA
    [DataMember, WritableValue, PropertyClassification("Service Level Loop", 290)]
    [XmlElement("HierarchicalLoop", Order = 29)]
    public ServiceLevelLoop217Review[] ServiceLevelLoop { get; set; } // 2000F
}