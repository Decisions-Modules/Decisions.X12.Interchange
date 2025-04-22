using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(STC))]
[DataContract]
[Writable]
public class STC
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Claim Status", 10)]
    public STC01 STC01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 20)]
    public string STC02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Action", 30)]
    public string STC03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Submitted Amount", 40)]
    public string STC04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amount Paid", 50)]
    public string STC05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 60)]
    public string STC06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Payment Method Code", 70)]
    public string STC07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Check Issue Date", 80)]
    public string STC08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Check Number", 90)]
    public string STC09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Status", 100)]
    public STC10 STC10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Status", 110)]
    public STC11 STC11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Message Text", 120)]
    public string STC12 { get; set; }
}

[DataContract]
[Writable]
public class STC01
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 10)]
    public string STC0101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string STC0102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 30)]
    public string STC0103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 40)]
    public string STC0104 { get; set; }
}

[DataContract]
[Writable]
public class STC10
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 10)]
    public string STC1001 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string STC1002 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 30)]
    public string STC1003 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 40)]
    public string STC1004 { get; set; }
}

[DataContract]
[Writable]
public class STC11
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 10)]
    public string STC1101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string STC1102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Entity Identifier Code", 30)]
    public string STC1103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 40)]
    public string STC1104 { get; set; }
}