using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SAC))]
[DataContract]
[Writable]
public class SAC
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Allowance or Charge Indicator", 10)]
    public string SAC01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service, Promotion, Allowance, or Charge Code", 20)]
    public string SAC02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Agency Qualifier Code", 30)]
    public string SAC03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Agency Service Code", 40)]
    public string SAC04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount", 50)]
    public string SAC05 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 130)]
    public string SAC13 { get; set; }
}
