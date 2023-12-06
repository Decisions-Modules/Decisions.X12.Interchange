using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class TEDLoop
{
    [DataMember, WritableValue, PropertyClassification("Technical Error Description", 10)]
    public TED TED { get; set; }
    [DataMember, WritableValue, PropertyClassification("Context", 20)]
    public CTX CTX { get; set; }
    [DataMember, WritableValue, PropertyClassification("Related Data", 40)]
    public RED RED { get; set; }
}