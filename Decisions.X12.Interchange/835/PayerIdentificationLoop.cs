using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract]
[Writable]
public class PayerIdentificationLoop // 1000A
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification", 10)]
    public N1 N1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address", 20)]
    public N3 N3 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("City, State, Zip Code", 30)]
    public N4 N4 { get; set; }

    [XmlElement("REF")]
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Additional Payer Identification", 40)]
    public REF[] REF { get; set; }

    [XmlElement("PER")]
    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contact Information", 50)]
    public PER[] PER { get; set; }
}