using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract]
[Writable]
public class Transaction835
{
    internal List<HeaderNumberLoop> HeaderNumberLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Financial Information", 20)]
    public BPR BPR { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reassociation Trace Number", 30)]
    public TRN TRN { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Foreign Currency Information", 40)]
    public CUR CUR { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification", 50)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Production Date", 60)]
    public DTM DTM { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payer Identification Loop", 70)]
    public PayerIdentificationLoop PayerIdentificationLoop { get; set; } // 1000A Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payee Identification Loop", 80)]
    public PayeeIdentificationLoop PayeeIdentificationLoop { get; set; } // 1000B Loop

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Header Number Loop", 90)]
    public HeaderNumberLoop[] HeaderNumberLoop { get; set; } //2000 Loop

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Adjustment", 100)]
    [XmlElement("PLB")]
    public PLB[] PLB { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 110)]
    public SE SE { get; set; }
}