using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange944;

[DataContract]
[Writable]
public class ItemDetailReceiptLoop944 // 0200 Loop
{
    internal List<ItemDetailExceptionLoop944> ItemDetailExceptionLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Detail - Warehouse Receipt", 10)]
    public W07 W07 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("G69")]
    [PropertyClassification("Free-Form Description", 20)]
    public G69[] G69 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 30)]
    public N9[] N9 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Detail Exception", 40)]
    public ItemDetailExceptionLoop944[] ItemDetailExceptionLoop { get; set; } // 0210 Loop
}
