using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CL1
{
    [DataMember, WritableValue, PropertyClassification("Admission Type Code", 10)]
    public string CL101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Admission Source Code", 20)]
    public string CL102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Status Code", 30)]
    public string CL103 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Nursing Home Residential Status Code", 40)]
    public string CL104 { get; set; }
}