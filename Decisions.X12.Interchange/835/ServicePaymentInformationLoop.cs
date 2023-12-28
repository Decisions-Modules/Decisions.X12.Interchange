using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class ServicePaymentInformationLoop // 2110 Loop
{
    [DataMember, WritableValue, PropertyClassification("Service Payment Information", 10)]
    public SVC SVC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Date", 20)]
    [XmlElement("DTM")]
    public DTM[] DTM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Adjustment", 30)]
    [XmlElement("CAS")]
    public CAS[] CAS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Identification", 40)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Amount", 50)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 60)]
    [XmlElement("QTY")]
    public QTY[] QTY { get; set; }
    [DataMember, WritableValue, PropertyClassification("Remark Codes", 70)]
    [XmlElement("LQ")]
    public LQ[] LQ { get; set; }
}