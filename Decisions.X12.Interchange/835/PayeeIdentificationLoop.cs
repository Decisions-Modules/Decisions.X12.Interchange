using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class PayeeIdentificationLoop // 1000B
{
    [DataMember, WritableValue, PropertyClassification("Identification", 10)]
    public N1 N1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address", 20)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("City, State, Zip Code", 30)]
    public N4 N4 { get; set; }
    [XmlElement("REF")]
    [DataMember, WritableValue, PropertyClassification("Additional Payer Identification", 40)]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Remittance Delivery Method", 50)]
    public RDM RDM { get; set; }
}