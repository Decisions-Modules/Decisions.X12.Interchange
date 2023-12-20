using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class RenderingProviderNameLoop222 // 2310B Loop
{
    [DataMember, WritableValue, PropertyClassification("Provider Name", 10)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Specialty Information", 20)]
    public PRV PRV { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Secondary Identification", 30)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
}