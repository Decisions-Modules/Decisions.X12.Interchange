using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class OTILoop
{
    [DataMember, WritableValue, PropertyClassification("Original Transaction Identification", 10)]
    public OTI OTI { get; set; }
    
    [XmlElement("REF")]
    [DataMember, WritableValue, PropertyClassification("Subscriber or Member Number", 20)]
    public REF[] REF { get; set; }
    
    [XmlElement("DTM")]
    [DataMember, WritableValue, PropertyClassification("Date and Time Qualifiers", 30)]
    public DTM[] DTM { get; set; }
    
    [XmlElement("PER")]
    [DataMember, WritableValue, PropertyClassification("Member Communications Numbers", 40)]
    public PER[] PER { get; set; }
    
    [XmlElement("AMT")]
    [DataMember, WritableValue, PropertyClassification("Monetary Amount Information", 50)]
    public AMT[] AMT { get; set; }
    
    [XmlElement("QTY")]
    [DataMember, WritableValue, PropertyClassification("Quantity Information", 60)]
    public QTY[] QTY { get; set; }
    
    [XmlElement("NM1")]
    [DataMember, WritableValue, PropertyClassification("Member Name", 70)]
    public NM1[] NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("TED Loop", 80)]
    public TEDLoop[] TEDLoop { get; set; }

    internal List<TEDLoop> TEDLoopForDeserialize;
}