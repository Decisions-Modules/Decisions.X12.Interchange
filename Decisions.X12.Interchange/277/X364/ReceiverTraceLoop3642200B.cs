using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract]
[Writable]
public class ReceiverTraceLoop3642200B // 2200B
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Application Trace Identifier", 10)]
    public TRN TRN { get; set; }

    [XmlElement("STC")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }

    [XmlElement("QTY")]
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 30)]
    public QTY[] QTY { get; set; }

    [XmlElement("AMT")]
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount", 40)]
    public AMT[] AMT { get; set; }
}