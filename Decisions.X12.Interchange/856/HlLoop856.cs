using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange856;

[DataContract]
[Writable]
public class HlLoop856 // HL Loop (all levels: S/O/P/I)
{
    internal List<NameAddressLoop856> NameAddressLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }

    // Shipment-level (HL03=S) segments
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("TD1")]
    [PropertyClassification("Carrier Details - Quantity/Weight", 20)]
    public TD1[] TD1 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("TD5")]
    [PropertyClassification("Carrier Details - Route", 30)]
    public TD5[] TD5 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("TD3")]
    [PropertyClassification("Carrier Details - Equipment", 40)]
    public TD3[] TD3 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("REF")]
    [PropertyClassification("Reference Identification", 50)]
    public REF[] REF { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [XmlElement("DTM")]
    [PropertyClassification("Date/Time Reference", 60)]
    public DTM[] DTM { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("F.O.B. Related Instructions", 70)]
    public FOB FOB { get; set; }

    // Order-level (HL03=O) segments
    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Purchase Order Reference", 80)]
    public PRF PRF { get; set; }

    // Pack-level (HL03=P) and Item-level (HL03=I) segments
    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [XmlElement("MAN")]
    [PropertyClassification("Marks and Numbers", 90)]
    public MAN[] MAN { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Physical Details", 100)]
    public PO4 PO4 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Item Identification", 110)]
    public LIN LIN { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Detail - Shipment", 120)]
    public SN1 SN1 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [XmlElement("PID")]
    [PropertyClassification("Product/Item Description", 130)]
    public PID[] PID { get; set; }

    // N1 sub-loop (name/address within HL)
    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loop", 140)]
    public NameAddressLoop856[] NameAddressLoop { get; set; }
}
