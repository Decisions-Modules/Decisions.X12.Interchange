using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(SV3))]
[DataContract]
[Writable]
public class SV3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Medical Procedure Identifier", 10)]
    public SV301 SV301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 20)]
    public string SV302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Facility Code Value", 30)]
    public string SV303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation", 40)]
    public SV304 SV304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Prosthesis, Crown or Inlay Code", 50)]
    public string SV305 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 60)]
    public string SV306 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SV307 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Copay Status Code", 80)]
    public string SV308 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Provider Agreement Code", 90)]
    public string SV309 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Response Code", 100)]
    public string SV310 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Diagnosis Code Pointer", 110)]
    public SV311 SV311 { get; set; }
}

[DataContract]
[Writable]
public class SV301
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string SV30101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 20)]
    public string SV30102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 30)]
    public string SV30103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 40)]
    public string SV30104 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 50)]
    public string SV30105 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Procedure Modifier", 60)]
    public string SV30106 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 70)]
    public string SV30107 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID", 80)]
    public string SV30108 { get; set; }
}

[DataContract]
[Writable]
public class SV304
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation Code", 10)]
    public string SV30401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation Code", 20)]
    public string SV30402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation Code", 30)]
    public string SV30403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation Code", 40)]
    public string SV30404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Oral Cavity Designation Code", 50)]
    public string SV30405 { get; set; }
}

[DataContract]
[Writable]
public class SV311
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Diagnosis Code Pointer", 10)]
    public string SV31101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Diagnosis Code Pointer", 20)]
    public string SV31102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Diagnosis Code Pointer", 30)]
    public string SV31103 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Diagnosis Code Pointer", 40)]
    public string SV31104 { get; set; }
}