using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange850;

[DataContract]
[Writable]
public class NameAddressLoop850 // N1 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 10)]
    public N1 N1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Name Information", 20)]
    public N2 N2 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("N3")]
    [PropertyClassification("Address Information", 30)]
    public N3[] N3 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Geographic Location", 40)]
    public N4 N4 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("PER")]
    [PropertyClassification("Administrative Communications Contact", 50)]
    public PER[] PER { get; set; }
}
