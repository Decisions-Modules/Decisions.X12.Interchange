using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(IK4))]
[DataContract]
[Writable]
public class IK4
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Position in Segment", 10)]
    public IK401 IK401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Reference Number", 20)]
    public string IK402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Implementation Data Element Syntax Error Code", 30)]
    public string IK403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Copy of Bad Data Element", 40)]
    public string IK404 { get; set; }
}

[DataContract]
[Writable]
public class IK401
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Element Position in Segment", 10)]
    public string IK40101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Component Data Element Position in Composite", 20)]
    public string IK40102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Repeating Data Element Position", 30)]
    public string IK40103 { get; set; }
}