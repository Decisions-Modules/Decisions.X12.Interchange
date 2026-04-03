using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange856;

[DataContract]
[Writable]
public class Transaction856
{
    internal List<HlLoop856> HlLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Ship Notice/Manifest", 20)]
    public BSN BSN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("DTM")]
    [PropertyClassification("Date/Time Reference", 30)]
    public DTM[] DTM { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Level Loops", 40)]
    public HlLoop856[] HlLoop { get; set; } // HL Loop

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Totals", 50)]
    public CTT CTT { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 60)]
    public SE SE { get; set; }
}
