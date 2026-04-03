using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(FOB))]
[DataContract]
[Writable]
public class FOB
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Shipment Method of Payment", 10)]
    public string FOB01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Weight Unit Code", 20)]
    public string FOB02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 30)]
    public string FOB03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Terms Qualifier Code", 40)]
    public string FOB04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transportation Terms Code", 50)]
    public string FOB05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Risk of Loss Code", 60)]
    public string FOB06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string FOB07 { get; set; }
}
