using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PO4))]
[DataContract]
[Writable]
public class PO4
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Pack", 10)]
    public string PO401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Size", 20)]
    public string PO402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code", 30)]
    public string PO403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Packaging Code", 40)]
    public string PO404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Qualifier", 50)]
    public string PO405 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Gross Weight Per Pack", 60)]
    public string PO406 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit of Measurement Code 2", 70)]
    public string PO407 { get; set; }
}
