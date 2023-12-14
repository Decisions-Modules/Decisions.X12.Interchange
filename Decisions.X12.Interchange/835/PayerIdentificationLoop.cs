using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class PayerIdentificationLoop // 1000A
{
    [DataMember, WritableValue, PropertyClassification("Identification", 10)]
    public N1 N1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address", 20)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("City, State, Zip Code", 30)]
    public N4 N4 { get; set; }
    [XmlElement("PER")]
    [DataMember, WritableValue, PropertyClassification("Technical Contact Information", 40)]
    public PER[] PER { get; set; }
    
}