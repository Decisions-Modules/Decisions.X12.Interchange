using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract]
[Writable]
public class FunctionGroup835
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Header", 10)]
    public GS GS { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction", 20)]
    public Transaction835 Transaction { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Trailer", 30)]
    public GE GE { get; set; }
}