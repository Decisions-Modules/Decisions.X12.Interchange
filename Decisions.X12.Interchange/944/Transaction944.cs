using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange944;

[DataContract]
[Writable]
public class Transaction944
{
    internal List<NameAddressLoop944> NameAddressLoopForDeserialize;
    internal List<ItemDetailReceiptLoop944> ItemDetailReceiptLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Stock Transfer Receipt", 20)]
    public W17 W17 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification", 30)]
    public N9[] N9 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("G62")]
    [PropertyClassification("Date/Time", 40)]
    public G62[] G62 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("NTE")]
    [PropertyClassification("Note/Special Instruction", 50)]
    public NTE[] NTE { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Carrier Details", 60)]
    public W08 W08 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loops", 70)]
    public NameAddressLoop944[] NameAddressLoop { get; set; } // 0100 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Detail Receipt Loops", 80)]
    public ItemDetailReceiptLoop944[] ItemDetailReceiptLoop { get; set; } // 0200 Loop

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Total Receipt", 90)]
    public W14 W14 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 100)]
    public SE SE { get; set; }
}
