using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK5
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Acknowledgement Code")]
    public string AK501 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Syntax Error Code")]
    public string AK502 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Syntax Error Code")]
    public string AK503 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Syntax Error Code")]
    public string AK504 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Syntax Error Code")]
    public string AK505 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Syntax Error Code")]
    public string AK506 { get; set; }
    
}