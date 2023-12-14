using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class ServicePaymentInformationLoop
{
    [DataMember, WritableValue, PropertyClassification("Service Payment Information", 10)]
    [XmlElement("SVC", Order = 1)]
    public SVC[] SVC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Date", 20)]
    [XmlElement("DTM", Order = 2)]
    public DTM[] DTM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Adjustment", 30)]
    [XmlElement("CAS", Order = 3)]
    public CAS[] CAS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Identification", 40)]
    [XmlElement("REF", Order = 4)]
    public REF[] REFServiceIdentification { get; set; }
    [DataMember, WritableValue, PropertyClassification("Control Number", 50)]
    [XmlElement("REF", Order = 5)]
    public REF REFControlNumber { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Information", 60)]
    [XmlElement("REF", Order = 6)]
    public REF[] REFProviderInformation { get; set; }
    [DataMember, WritableValue, PropertyClassification("Policy Identification", 70)]
    [XmlElement("REF", Order = 7)]
    public REF[] REFPolicyIdentification { get; set; }
    [DataMember, WritableValue, PropertyClassification("Amount", 80)]
    [XmlElement("AMT", Order = 8)]
    public AMT[] AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 90)]
    [XmlElement("QTY", Order = 9)]
    public QTY[] QTY { get; set; }
    [DataMember, WritableValue, PropertyClassification("Remark Codes", 100)]
    [XmlElement("LQ", Order = 10)]
    public LQ[] LQ { get; set; }
}