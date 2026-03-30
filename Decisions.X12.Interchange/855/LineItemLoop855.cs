using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange855;

[DataContract]
[Writable]
public class LineItemLoop855 // PO1 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Baseline Item Data", 10)]
    public PO1 PO1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("SLN")]
    [PropertyClassification("Subline Item Detail", 20)]
    public SLN[] SLN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("PID")]
    [PropertyClassification("Product/Item Description", 30)]
    public PID[] PID { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("ACK")]
    [PropertyClassification("Line Item Acknowledgment", 40)]
    public ACK[] ACK { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 50)]
    public N9[] N9 { get; set; }
}
