using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(BHT))]
[DataContract]
[Writable]
public class BHT
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Hierarchical Structure Code", 10)]
    public string BHT01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Purpose Code", 20)]
    public string BHT02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 30)]
    public string BHT03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 40)]
    public string BHT04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Time", 50)]
    public string BHT05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Type Code", 50)]
    public string BHT06 { get; set; }
}