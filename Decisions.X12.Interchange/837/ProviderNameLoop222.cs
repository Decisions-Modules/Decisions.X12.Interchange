using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class ProviderNameLoop222 // Loop 2010AA
{
    [DataMember, WritableValue, PropertyClassification("Name", 10)]
    [XmlElement("NM1")]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address", 20)]
    [XmlElement("N3")]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("City, State, Zip Code", 30)]
    [XmlElement("N4")]
    public N4 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Informaion", 40)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Contact Information", 50)]
    [XmlElement("PER")]
    public PER[] PER { get; set; }
}