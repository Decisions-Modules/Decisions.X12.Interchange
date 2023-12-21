using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange999;

[DataContract, Writable]
public class ErrorIdentificationLoop2100
{
    [DataMember, WritableValue, PropertyClassification("Error Identification", 10)]
    public IK3 IK3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Context", 20)]
    [XmlElement("CTX")]
    public CTX[] CTX { get; set; }
    
    // 2110 Loop
    [DataMember, WritableValue, PropertyClassification("Implementation Data Element Note Loop", 30)]
    public ImplementationDataElementNoteLoop2110[] ImplementationDataElementNoteLoop2110 { get; set; }

    internal List<ImplementationDataElementNoteLoop2110> ImplementationDataElementNoteLoop2110ForDeserialize;
}