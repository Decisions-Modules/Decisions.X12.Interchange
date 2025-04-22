using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange997;

public class Transaction997
{
    internal List<TransactionSetResponseHeaderLoop2000> TransactionSetResponseHeaderLoop2000ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Response Header", 20)]
    public AK1 AK1 { get; set; }

    // 2000 Loop
    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Response Header Loop", 30)]
    public TransactionSetResponseHeaderLoop2000[] TransactionSetResponseHeaderLoop2000 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Response Trailer", 40)]
    public AK9 AK9 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 50)]
    public SE SE { get; set; }
}