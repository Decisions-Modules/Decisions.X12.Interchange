using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange810;

[DataContract]
[Writable]
public class InvoiceLineItemLoop810 // IT1 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Baseline Item Data", 10)]
    public IT1 IT1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [XmlElement("IT3")]
    [PropertyClassification("Additional Item Data", 20)]
    public IT3[] IT3 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Pricing Information", 30)]
    public CTP CTP { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [XmlElement("PID")]
    [PropertyClassification("Product/Item Description", 40)]
    public PID[] PID { get; set; }
}
