using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract]
[Writable]
public class OTILoop
{
    internal List<LMLoop> LMLoopForDeserialize;

    internal List<TEDLoop> TEDLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Original Transaction Identification", 10)]
    public OTI OTI { get; set; }

    [XmlElement("REF")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Subscriber or Member Number", 20)]
    public REF[] REF { get; set; }

    [XmlElement("DTM")]
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date and Time Qualifiers", 30)]
    public DTM[] DTM { get; set; }

    [XmlElement("PER")]
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Communications Numbers", 40)]
    public PER[] PER { get; set; }

    [XmlElement("AMT")]
    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount Information", 50)]
    public AMT[] AMT { get; set; }

    [XmlElement("QTY")]
    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity Information", 60)]
    public QTY[] QTY { get; set; }

    [XmlElement("NM1")]
    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Name", 70)]
    public NM1[] NM1 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("TED Loop", 80)]
    public TEDLoop[] TEDLoop { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("LM Loop", 90)]
    public LMLoop[] LMLoop { get; set; }
}