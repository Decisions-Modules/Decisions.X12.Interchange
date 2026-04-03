using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange940;

[DataContract]
[Writable]
public class Transaction940
{
    internal List<NameAddressLoop940> NameAddressLoopForDeserialize;
    internal List<AssignedNumberLoop940> AssignedNumberLoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Warehouse Order Activity", 20)]
    public W05 W05 { get; set; }

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
    public W66 W66 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name/Address Loops", 70)]
    public NameAddressLoop940[] NameAddressLoop { get; set; } // 0100 Loop

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Assigned Number Loops", 80)]
    public AssignedNumberLoop940[] AssignedNumberLoop { get; set; } // 0300 Loop

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 90)]
    public SE SE { get; set; }
}
