using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class SV1
{
    [DataMember, WritableValue, PropertyClassification("Composite Medical Procedure Identifier", 10)]
    public SV101 SV101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string SV102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit of Measurement Code", 30)]
    public string SV103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 40)]
    public string SV104 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Facility Code Value", 50)]
    public string SV105 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Type Code", 60)]
    public string SV106 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Composite Diagnosis Code Pointer", 70)]
    public SV107 SV107 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string SV108 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 90)]
    public string SV109 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiple Procedure Code", 100)]
    public SV101 SV110 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 110)]
    public string SV111 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 120)]
    public string SV112 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Review Code", 130)]
    public string SV113 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Assigned Review Value", 140)]
    public string SV114 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Copay Status Code", 150)]
    public string SV115 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Care Professional Shortage Area Code", 160)]
    public string SV116 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 170)]
    public SV107 SV117 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Postal Code", 180)]
    public string SV118 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 190)]
    public string SV119 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Level of Care Code", 200)]
    public string SV120 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Agreement Code", 210)]
    public string SV121 { get; set; }
}

[DataContract, Writable]
public class SV101
{
    [DataMember, WritableValue, PropertyClassification("Service ID Qualifier", 10)]
    public string SV10101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service ID", 20)]
    public string SV10102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 30)]
    public string SV10103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 40)]
    public string SV10104 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 50)]
    public string SV10105 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 60)]
    public string SV10106 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 70)]
    public string SV10107 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service ID", 80)]
    public string SV10108 { get; set; }
}

[DataContract, Writable]
public class SV107
{
    [DataMember, WritableValue, PropertyClassification("Diagnosis Code Pointer", 10)]
    public string SV10701 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Diagnosis Code Pointer", 20)]
    public string SV10702 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Diagnosis Code Pointer", 30)]
    public string SV10703 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Diagnosis Code Pointer", 40)]
    public string SV10704 { get; set; }
}