using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ReceiverTraceLoop364 // 2200B
{
    [DataMember, WritableValue, PropertyClassification("Application Trace Identifier", 10)]
    [XmlElement("TRN", Order = 1)]
    public TRN TRN { get; set; }
    [XmlElement("STC", Order = 2)]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [XmlElement("QTY", Order = 3)]
    [DataMember, WritableValue, PropertyClassification("Accepted Quantity", 30)]
    public QTY AcceptedQTY { get; set; }
    [XmlElement("QTY", Order = 4)]
    [DataMember, WritableValue, PropertyClassification("Rejected Quantity", 40)]
    public QTY RejectedQTY { get; set; }
    [XmlElement("AMT", Order = 5)]
    [DataMember, WritableValue, PropertyClassification("Accepted Amount", 50)]
    public AMT AccpetedAMT { get; set; }
    [XmlElement("AMT", Order = 6)]
    [DataMember, WritableValue, PropertyClassification("Rejected Amount", 60)]
    public AMT[] RejectedAMT { get; set; }
}