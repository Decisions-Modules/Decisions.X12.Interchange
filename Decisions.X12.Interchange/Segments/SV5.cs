using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SV5))]
[DataContract]
[Writable]
public class SV5
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 10)]
    public SV501 SV501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 20)]
    public string SV502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 30)]
    public string SV503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 40)]
    public string SV504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string SV505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Frequency Code", 60)]
    public string SV506 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Prognosis Code", 70)]
    public string SV507 { get; set; }
}

[DataContract]
[Writable]
public class SV501
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string SV50101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 20)]
    public string SV50102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SV50103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SV50104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SV50105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SV50106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SV50107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 80)]
    public string SV50108 { get; set; }
}