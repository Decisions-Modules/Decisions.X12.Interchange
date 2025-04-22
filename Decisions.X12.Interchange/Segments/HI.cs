using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(HI))]
[DataContract]
[Writable]
public class HI
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 10)]
    public HI01 HI01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 20)]
    public HI02 HI02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 30)]
    public HI03 HI03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 40)]
    public HI04 HI04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 50)]
    public HI05 HI05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 60)]
    public HI06 HI06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 70)]
    public HI07 HI07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 80)]
    public HI08 HI08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 90)]
    public HI09 HI09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 100)]
    public HI10 HI10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 110)]
    public HI11 HI11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Health Care Code Information", 120)]
    public HI12 HI12 { get; set; }
}

[DataContract]
[Writable]
public class HI01
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0108 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0109 { get; set; }
}

[DataContract]
[Writable]
public class HI02
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0208 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0209 { get; set; }
}

[DataContract]
[Writable]
public class HI03
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0305 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0306 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0307 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0308 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0309 { get; set; }
}

[DataContract]
[Writable]
public class HI04
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0405 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0406 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0407 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0408 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0409 { get; set; }
}

[DataContract]
[Writable]
public class HI05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0506 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0507 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0508 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0509 { get; set; }
}

[DataContract]
[Writable]
public class HI06
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0601 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0602 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0603 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0604 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0605 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0606 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0607 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0608 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0609 { get; set; }
}

[DataContract]
[Writable]
public class HI07
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0701 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0702 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0703 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0704 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0705 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0706 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0707 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0708 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0709 { get; set; }
}

[DataContract]
[Writable]
public class HI08
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0801 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0802 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0803 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0804 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0805 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0806 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0807 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0808 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0809 { get; set; }
}

[DataContract]
[Writable]
public class HI09
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI0901 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI0902 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI0903 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI0904 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI0905 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI0906 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI0907 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI0908 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI0909 { get; set; }
}

[DataContract]
[Writable]
public class HI10
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI1001 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI1002 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI1003 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI1004 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI1005 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI1006 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI1007 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI1008 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI1009 { get; set; }
}

[DataContract]
[Writable]
public class HI11
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI1101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI1102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI1103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI1104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI1105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI1106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI1107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI1108 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI1109 { get; set; }
}

[DataContract]
[Writable]
public class HI12
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string HI1201 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string HI1202 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period Format Qualifier", 30)]
    public string HI1203 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date Time Period", 40)]
    public string HI1204 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 50)]
    public string HI1205 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string HI1206 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version Identifier", 70)]
    public string HI1207 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 80)]
    public string HI1208 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 90)]
    public string HI1209 { get; set; }
}