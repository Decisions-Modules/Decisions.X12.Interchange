using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange945;

[DataContract]
[Writable]
public class Transaction945
{
    internal List<NameAddressLoop945> NameAddressLoopForDeserialize;
    internal List<AssignedNumberLoop945> AssignedNumberLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Shipping Advice", 20)]
    public W06 W06 { get; set; }

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
    [PropertyClassification("Carrier Details", 50)]
    public W27 W27 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loops", 60)]
    public NameAddressLoop945[] NameAddressLoop { get; set; } // 0100 Loop

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Number Loops", 70)]
    public AssignedNumberLoop945[] AssignedNumberLoop { get; set; } // 0300 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 80)]
    public SE SE { get; set; }
}
