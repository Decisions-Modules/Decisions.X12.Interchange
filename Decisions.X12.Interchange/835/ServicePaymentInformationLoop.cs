using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract]
[Writable]
public class ServicePaymentInformationLoop // 2110 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Payment Information", 10)]
    public SVC SVC { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Date", 20)]
    [XmlElement("DTM")]
    public DTM[] DTM { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Adjustment", 30)]
    [XmlElement("CAS")]
    public CAS[] CAS { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Identification", 40)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount", 50)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    [XmlElement("QTY")]
    public QTY[] QTY { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Remark Codes", 70)]
    [XmlElement("LQ")]
    public LQ[] LQ { get; set; }
}