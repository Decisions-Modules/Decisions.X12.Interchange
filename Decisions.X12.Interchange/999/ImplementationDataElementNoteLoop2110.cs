using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange999;

[DataContract]
[Writable]
public class ImplementationDataElementNoteLoop2110 // 2110
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Implementation Data Element Note", 10)]
    public IK4 IK4 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Element Context", 20)]
    [XmlElement("CTX")]
    public CTX[] CTX { get; set; }
}