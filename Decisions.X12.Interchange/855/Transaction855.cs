using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange855;

[DataContract]
[Writable]
public class Transaction855
{
    internal List<NameAddressLoop855> NameAddressLoopForDeserialize;
    internal List<LineItemLoop855> LineItemLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Acknowledgment Header", 20)]
    public BAK BAK { get; set; }

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
    [PropertyClassification("Name/Address Loops", 60)]
    public NameAddressLoop855[] NameAddressLoop { get; set; } // N1 Loop

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Item Loops", 70)]
    public LineItemLoop855[] LineItemLoop { get; set; } // PO1 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Totals", 80)]
    public CTT CTT { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 90)]
    public SE SE { get; set; }
}
