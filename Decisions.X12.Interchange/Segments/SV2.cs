using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SV2))]
[DataContract]
[Writable]
public class SV2
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 10)]
    public string SV201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 20)]
    public SV202 SV202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 30)]
    public string SV203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 40)]
    public string SV204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 50)]
    public string SV205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit Rate", 60)]
    public string SV206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 70)]
    public string SV207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 80)]
    public string SV208 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Nursing Home Residential Status Code", 90)]
    public string SV209 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Level of Care Code", 100)]
    public string SV210 { get; set; }
}

[DataContract]
[Writable]
public class SV202
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string SV20201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 20)]
    public string SV20202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SV20203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SV20204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SV20205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SV20206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SV20207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 80)]
    public string SV20208 { get; set; }
}