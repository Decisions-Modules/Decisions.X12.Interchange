using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class FunctionGroup222
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Header", 10)]
    public GS GS { get; set; }

    [XmlIgnore]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction", 20)]
    public Transaction222 Transaction
    {
        get => Transactions?.FirstOrDefault();
        set { }
    }

    [EdiElement(1)]
    [XmlElement("Transaction")]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transactions", 30)]
    public List<Transaction222> Transactions { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Trailer", 40)]
    public GE GE { get; set; }
}