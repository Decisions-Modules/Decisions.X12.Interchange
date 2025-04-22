using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PWK))]
[DataContract]
[Writable]
public class PWK
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 10)]
    public string PWK01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Transmission Code", 20)]
    public string PWK02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Copies Needed", 30)]
    public string PWK03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 40)]
    public string PWK04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code Qualifier", 50)]
    public string PWK05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Identification Code", 60)]
    public string PWK06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string PWK07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Actions Indicated", 80)]
    public PWK08 PWK08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Request Category Code", 90)]
    public string PWK09 { get; set; }
}

[DataContract]
[Writable]
public class PWK08
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 10)]
    public string PWK0801 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 20)]
    public string PWK0802 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 30)]
    public string PWK0803 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 40)]
    public string PWK0804 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Report Type Code", 50)]
    public string PWK0805 { get; set; }
}