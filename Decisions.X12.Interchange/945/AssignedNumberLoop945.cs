using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange945;

[DataContract]
[Writable]
public class AssignedNumberLoop945 // 0300 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Number", 10)]
    public LX LX { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("MAN")]
    [PropertyClassification("Marks and Numbers", 20)]
    public MAN[] MAN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("W12")]
    [PropertyClassification("Warehouse Item Detail", 30)]
    public W12[] W12 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Total Shipment Information", 40)]
    public W03 W03 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 50)]
    public N9[] N9 { get; set; }
}
