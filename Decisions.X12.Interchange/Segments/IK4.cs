using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class IK4
{
    [DataMember, WritableValue, PropertyClassification("Position in Segment", 10)]
    public IK401 IK401 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Data Element Reference Number", 20)]
    public string IK402 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Data Element Syntax Error Code", 30)]
    public string IK403 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Copy of Bad Data Element", 40)]
    public string IK404 { get; set; }
}

[DataContract, Writable]
public class IK401
{
    [DataMember, WritableValue, PropertyClassification("Element Position in Segment", 10)]
    public string IK40101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Component Data Element Position in Composite", 20)]
    public string IK40102 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Repeating Data Element Position", 30)]
    public string IK40103 { get; set; }
}