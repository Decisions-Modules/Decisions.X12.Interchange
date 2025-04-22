using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract]
[Writable]
public class N1Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 10)]
    public N1 N1 { get; set; }

    [XmlElement("N2")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Name Information", 20)]
    public N2[] N2 { get; set; }

    [XmlElement("N3")]
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Residence Street Address", 30)]
    public N3[] N3 { get; set; }

    [XmlElement("N4")]
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Residence City, State, Zip", 40)]
    public N4 N4 { get; set; }

    [XmlElement("REF")]
    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Information", 50)]
    public REF[] REF { get; set; }

    [XmlElement("PER")]
    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Communications Numbers", 60)]
    public PER[] PER { get; set; }
}