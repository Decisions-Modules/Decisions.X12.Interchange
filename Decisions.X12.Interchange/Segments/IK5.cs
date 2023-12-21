using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class IK5
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Acknowledgment Code", 10)]
    public string IK501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Transaction Set Syntax Error Code", 20)]
    public string IK502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Transaction Set Syntax Error Code", 30)]
    public string IK503 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Transaction Set Syntax Error Code", 40)]
    public string IK504 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Transaction Set Syntax Error Code", 50)]
    public string IK505 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Implementation Transaction Set Syntax Error Code", 60)]
    public string IK506 { get; set; }
}