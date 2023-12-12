using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ServiceLineLoop364 // 2220 Loop
{
    [XmlElement("SVC", Order = 1)]
    [DataMember, WritableValue, PropertyClassification("Service Information", 10)]
    public SVC SVC { get; set; }
    
    [XmlElement("STC", Order = 2)]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    
    [XmlElement("REF", Order = 3)]
    [DataMember, WritableValue, PropertyClassification("Line Item Control Number", 30)]
    public REF LineItemControlNumber { get; set; }
    
    [XmlElement("REF", Order = 4)]
    [DataMember, WritableValue, PropertyClassification("Pharmacy Prescription Number", 40)]
    public REF PharmacyPrescriptionNumber { get; set; }
    
    [XmlElement("DTP", Order = 5)]
    [DataMember, WritableValue, PropertyClassification("Date", 50)]
    public DTP DTP { get; set; }
}