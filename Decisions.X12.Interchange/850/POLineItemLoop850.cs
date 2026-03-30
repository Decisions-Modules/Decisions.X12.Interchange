using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange850;

[DataContract]
[Writable]
public class POLineItemLoop850 // PO1 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Baseline Item Data", 10)]
    public PO1 PO1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Pricing Information", 20)]
    public CTP CTP { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [XmlElement("PID")]
    [PropertyClassification("Product/Item Description", 30)]
    public PID[] PID { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Physical Details", 40)]
    public PO4 PO4 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [XmlElement("DTM")]
    [PropertyClassification("Date/Time Reference", 50)]
    public DTM[] DTM { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Commodity", 60)]
    public TC2 TC2 { get; set; }
}
