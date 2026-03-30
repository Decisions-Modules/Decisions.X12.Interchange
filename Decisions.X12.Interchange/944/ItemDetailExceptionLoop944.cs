using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange944;

[DataContract]
[Writable]
public class ItemDetailExceptionLoop944 // 0210 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Detail Exception", 10)]
    public W13 W13 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 20)]
    public N9[] N9 { get; set; }
}
