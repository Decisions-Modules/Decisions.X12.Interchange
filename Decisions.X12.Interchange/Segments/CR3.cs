using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CR3))]
[DataContract]
[Writable]
public class CR3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Certification Type Code", 10)]
    public string CR301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 20)]
    public string CR302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 30)]
    public string CR303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Insuline Dependent Code", 40)]
    public string CR304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 50)]
    public string CR305 { get; set; }
}