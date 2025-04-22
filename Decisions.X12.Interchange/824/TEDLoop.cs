using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract]
[Writable]
public class TEDLoop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Technical Error Description", 10)]
    public TED TED { get; set; }

    [XmlElement("CTX")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Context", 20)]
    public CTX[] CTX { get; set; }

    [XmlElement("NTE")]
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Note/Special Instruction", 30)]
    public NTE[] NTE { get; set; }

    [XmlElement("RED")]
    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related Data", 40)]
    public RED[] RED { get; set; }
}