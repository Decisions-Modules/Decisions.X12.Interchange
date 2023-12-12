using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ProviderTraceLoop364 // 2200C Loop
{
    [DataMember, WritableValue, PropertyClassification("Application Trace Identifier", 10)]
    [XmlElement("TRN", Order = 1)]
    public TRN TRN { get; set; }
    [XmlElement("STC", Order = 2)]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Secondary Identifier", 30)]
    [XmlElement("REF", Order = 3)]
    public REF[] REF { get; set; }
    [XmlElement("QTY", Order = 4)]
    [DataMember, WritableValue, PropertyClassification("Accepted Quantity", 40)]
    public QTY AcceptedQTY { get; set; }
    [XmlElement("QTY", Order = 5)]
    [DataMember, WritableValue, PropertyClassification("Rejected Quantity", 50)]
    public QTY RejectedQTY { get; set; }
    [XmlElement("AMT", Order = 6)]
    [DataMember, WritableValue, PropertyClassification("Accepted Amount", 60)]
    public AMT AccpetedAMT { get; set; }
    [XmlElement("AMT", Order = 7)]
    [DataMember, WritableValue, PropertyClassification("Rejected Amount", 70)]
    public AMT[] RejectedAMT { get; set; }
}