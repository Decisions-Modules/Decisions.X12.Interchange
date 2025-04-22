using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CLM))]
[DataContract]
[Writable]
public class CLM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Submitter's Identifier", 10)]
    public string CLM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string CLM02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Filing Indicator Code", 30)]
    public string CLM03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Non-Institutional Claim Type Code", 40)]
    public string CLM04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Service Location Information", 50)]
    public CLM05 CLM05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition or Response Code", 60)]
    public string CLM06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Accept Assignment Code", 70)]
    public string CLM07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition or Response Code", 80)]
    public string CLM08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Release of Information Code", 90)]
    public string CLM09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Patient Signature Source Code", 100)]
    public string CLM10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related Causes Information", 110)]
    public CLM11 CLM11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Special Program Code", 120)]
    public string CLM12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition or Response Code", 130)]
    public string CLM13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Level of Service Code", 140)]
    public string CLM14 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition or Response Code", 150)]
    public string CLM15 { get; set; }

    [EdiElement(15)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Agreement Code", 160)]
    public string CLM16 { get; set; }

    [EdiElement(16)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Status Code", 170)]
    public string CLM17 { get; set; }

    [EdiElement(17)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Yes/No Condition or Response Code", 180)]
    public string CLM18 { get; set; }

    [EdiElement(18)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Submission Reason Code", 190)]
    public string CLM19 { get; set; }

    [EdiElement(19)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Delay Reason Code", 200)]
    public string CLM20 { get; set; }
}

[DataContract]
[Writable]
public class CLM05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Value", 10)]
    public string CLM0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Qualifier", 20)]
    public string CLM0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Frequency Type Code", 30)]
    public string CLM0503 { get; set; }
}

[DataContract]
[Writable]
public class CLM11
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 10)]
    public string CLM1101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 20)]
    public string CLM1102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Related-Causes Code", 30)]
    public string CLM1103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("State or Province Code", 40)]
    public string CLM1104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Country Code", 50)]
    public string CLM1105 { get; set; }
}