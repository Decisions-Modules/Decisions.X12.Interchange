using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(UM))]
[DataContract]
[Writable]
public class UM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Request Category Code", 10)]
    public string UM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Certification Type Code", 20)]
    public string UM02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Type Code", 30)]
    public string UM03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Service Location Information", 40)]
    public UM04 UM04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related Causes Information", 50)]
    public UM05 UM05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Level of Service Code", 60)]
    public string UM06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Current Health Condition Code", 70)]
    public string UM07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Prognosis Code", 80)]
    public string UM08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Release of Information Code", 90)]
    public string UM09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Delay Reason Code", 100)]
    public string UM10 { get; set; }
}

[DataContract]
[Writable]
public class UM04
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Value", 10)]
    public string UM0401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Qualifier", 20)]
    public string UM0402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Frequency Type Code", 30)]
    public string UM0403 { get; set; }
}

[DataContract]
[Writable]
public class UM05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 10)]
    public string UM0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 20)]
    public string UM0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 30)]
    public string UM0503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("State or Province Code", 40)]
    public string UM0504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Country Code", 50)]
    public string UM0505 { get; set; }
}