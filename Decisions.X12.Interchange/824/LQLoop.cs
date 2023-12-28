using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class LQLoop
{
    [DataMember, WritableValue, PropertyClassification("Industry Code Identification", 10)]
    public LQ LQ { get; set; }
    [XmlElement("RED")]
    [DataMember, WritableValue, PropertyClassification("Related Data", 20)]
    public RED[] RED { get; set; }
}