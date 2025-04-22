using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SVC))]
[DataContract]
[Writable]
public class SVC
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 10)]
    public SVC01 SVC01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string SVC02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 30)]
    public string SVC03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 40)]
    public string SVC04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 50)]
    public string SVC05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 60)]
    public SVC06 SVC06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 70)]
    public string SVC07 { get; set; }
}

[DataContract]
[Writable]
public class SVC01
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string SVC0101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 20)]
    public string SVC0102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SVC0103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SVC0104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SVC0105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SVC0106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SVC0107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 80)]
    public string SVC0108 { get; set; }
}

[DataContract]
[Writable]
public class SVC06
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string SVC0601 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 20)]
    public string SVC0602 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SVC0603 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SVC0604 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SVC0605 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SVC0606 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SVC0607 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 80)]
    public string SVC0608 { get; set; }
}