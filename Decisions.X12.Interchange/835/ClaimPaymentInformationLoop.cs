using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract]
[Writable]
public class ClaimPaymentInformationLoop // 2100 Loop
{
    internal List<ServicePaymentInformationLoop> ServicePaymentInformationLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Payment Information", 10)]
    public CLP CLP { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Adjustment", 20)]
    [XmlElement("CAS")]
    public CAS[] CAS { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 30)]
    [XmlElement("NM1")]
    public NM1[] NM1 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Inpatient Adjudication Information", 40)]
    public MIA MIA { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Outpatient Adjudication Information", 50)]
    public MOA MOA { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification", 60)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 70)]
    [XmlElement("DTM")]
    public DTM[] DTM { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contact Information", 80)]
    [XmlElement("PER")]
    public PER[] PER { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Supplemental Information", 90)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Supplemental Information Quantity", 100)]
    [XmlElement("QTY")]
    public QTY[] QTY { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Payment Information Loop", 110)]
    public ServicePaymentInformationLoop[] ServicePaymentInformationLoop { get; set; } // 2110 loop
}