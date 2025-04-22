using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange999;

[DataContract]
[Writable]
public class ErrorIdentificationLoop2100 // 2100
{
    internal List<ImplementationDataElementNoteLoop2110> ImplementationDataElementNoteLoop2110ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Error Identification", 10)]
    public IK3 IK3 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Context", 20)]
    [XmlElement("CTX")]
    public CTX[] CTX { get; set; }

    // 2110 Loop
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Implementation Data Element Note Loop", 30)]
    public ImplementationDataElementNoteLoop2110[] ImplementationDataElementNoteLoop2110 { get; set; }
}