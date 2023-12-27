using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ServiceLineLoop3642220D // 2220 Loop
{
    [DataMember, WritableValue, PropertyClassification("Service Information", 10)]
    public SVC SVC { get; set; }
    [XmlElement("STC")]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [XmlElement("REF")]
    [DataMember, WritableValue, PropertyClassification("Secondary Information", 30)]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 40)]
    public DTP DTP { get; set; }
}