using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ProviderTraceLoop3642200C // 2200C Loop
{
    [DataMember, WritableValue, PropertyClassification("Application Trace Identifier", 10)]
    public TRN TRN { get; set; }
    [XmlElement("STC")]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Secondary Information", 30)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [XmlElement("QTY")]
    [DataMember, WritableValue, PropertyClassification("Quantity", 40)]
    public QTY[] QTY { get; set; }
    [XmlElement("AMT")]
    [DataMember, WritableValue, PropertyClassification("Amount", 50)]
    public AMT[] AMT { get; set; }
}