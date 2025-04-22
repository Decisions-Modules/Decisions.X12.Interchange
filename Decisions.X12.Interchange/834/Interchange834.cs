using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class Interchange
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Segment Terminator", 1)]
    [XmlAttribute("segment-terminator")]
    public string SegmentTerminator { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Element Separator", 2)]
    [XmlAttribute("element-separator")]
    public string ElementSeparator { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Sub Element Separator", 3)]
    [XmlAttribute("sub-element-separator")]
    public string SubElementSeparator { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Header", 10)]
    public ISA ISA { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group", 20)]
    public FunctionalGroup834 FunctionGroup { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Interchange Control Trailer", 30)]
    public IEA IEA { get; set; }
}