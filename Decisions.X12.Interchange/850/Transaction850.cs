using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange850;

[DataContract]
[Writable]
public class Transaction850
{
    internal List<NameAddressLoop850> NameAddressLoopForDeserialize;
    internal List<POLineItemLoop850> POLineItemLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Beginning Segment for Purchase Order", 20)]
    public BEG BEG { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("REF")]
    [PropertyClassification("Reference Identification", 30)]
    public REF[] REF { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("PER")]
    [PropertyClassification("Administrative Communications Contact", 40)]
    public PER[] PER { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("DTM")]
    [PropertyClassification("Date/Time Reference", 50)]
    public DTM[] DTM { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [XmlElement("N9")]
    [PropertyClassification("Reference Identification (N9)", 60)]
    public N9[] N9 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loops", 70)]
    public NameAddressLoop850[] NameAddressLoop { get; set; } // N1 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("PO Line Item Loops", 80)]
    public POLineItemLoop850[] POLineItemLoop { get; set; } // PO1 Loop

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Totals", 90)]
    public CTT CTT { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 100)]
    public SE SE { get; set; }
}
