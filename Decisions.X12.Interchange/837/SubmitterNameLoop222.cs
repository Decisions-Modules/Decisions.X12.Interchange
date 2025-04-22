using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class SubmitterNameLoop222 // 1000A
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 10)]
    public NM1 NM1 { get; set; }

    [XmlElement("PER")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Contact Information", 20)]
    public PER[] PER { get; set; }
}