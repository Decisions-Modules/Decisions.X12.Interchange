using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange940;

[DataContract]
[Writable]
public class AssignedNumberLoop940 // 0300 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Number", 10)]
    public LX LX { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("W01")]
    [PropertyClassification("Warehouse Item Detail", 20)]
    public W01[] W01 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("G69")]
    [PropertyClassification("Free-Form Description", 30)]
    public G69[] G69 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Total Order Information", 40)]
    public W76 W76 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 50)]
    public N9[] N9 { get; set; }
}
