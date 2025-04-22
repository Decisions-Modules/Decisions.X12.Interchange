using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK4
{
    [DataMember, WritableValue, PropertyClassification("Position in Segment", 10)]
    public C030 AK401 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Data Element Reference Code", 20)]
    public string AK402 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Data Element Syntax Error Code", 30)]
    public string AK403 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Copy of Bad Data Element", 40)]
    public string AK404 { get; set; }
}