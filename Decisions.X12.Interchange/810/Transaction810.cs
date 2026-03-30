using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange810;

[DataContract]
[Writable]
public class Transaction810
{
    internal List<NameAddressLoop810> NameAddressLoopForDeserialize;
    internal List<InvoiceLineItemLoop810> InvoiceLineItemLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Beginning Segment for Invoice", 20)]
    public BIG BIG { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("NTE")]
    [PropertyClassification("Note/Special Instruction", 30)]
    public NTE[] NTE { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("REF")]
    [PropertyClassification("Reference Identification", 40)]
    public REF[] REF { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("DTM")]
    [PropertyClassification("Date/Time Reference", 50)]
    public DTM[] DTM { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loops", 60)]
    public NameAddressLoop810[] NameAddressLoop { get; set; } // N1 Loop

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Invoice Line Item Loops", 70)]
    public InvoiceLineItemLoop810[] InvoiceLineItemLoop { get; set; } // IT1 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Total Monetary Value Summary", 80)]
    public TDS TDS { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [XmlElement("SAC")]
    [PropertyClassification("Service, Promotion, Allowance, or Charge", 90)]
    public SAC[] SAC { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Totals", 100)]
    public CTT CTT { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 110)]
    public SE SE { get; set; }
}
