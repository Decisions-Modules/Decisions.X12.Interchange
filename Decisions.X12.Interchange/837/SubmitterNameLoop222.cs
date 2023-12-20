using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace X12Interchange837
{
    [DataContract, Writable]
    public class SubmitterNameLoop222 // 1000A
    {
        [DataMember, WritableValue, PropertyClassification("Name", 10)]
        public NM1 NM1 { get; set; }
        [XmlElement("PER")]
        [DataMember, WritableValue, PropertyClassification("Contact Information", 20)]
        public PER[] PER { get; set; }

    }
}
