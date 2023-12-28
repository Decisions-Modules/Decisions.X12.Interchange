using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class RDM
{
    [DataMember, WritableValue, PropertyClassification("Report Transmission Code", 10)]
    public string RDM01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name", 20)]
    public string RDM02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Communication Number", 30)]
    public string RDM03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identifier", 40)]
    public RDM04 RDM04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identifier", 50)]
    public RDM05 RDM05 { get; set; }
}
[DataContract, Writable]
public class RDM04
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 10)]
    public string RDM0401 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string RDM0402 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 30)]
    public string RDM0403 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 40)]
    public string RDM0404 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 50)]
    public string RDM0405 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 60)]
    public string RDM0406 { get; set; }
}
[DataContract, Writable]
public class RDM05
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 10)]
    public string RDM0501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string RDM0502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 30)]
    public string RDM0503 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 40)]
    public string RDM0504 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 50)]
    public string RDM0505 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 60)]
    public string RDM0506 { get; set; }
}