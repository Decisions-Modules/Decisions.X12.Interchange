using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class AK9
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Acknowledge Code", 10)]
    public string AK901 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Number of Transaction Sets Included", 20)]
    public string AK902 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Number of Received Transaction Sets", 30)]
    public string AK903 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Number of Accepted Transaction Sets", 40)]
    public string AK904 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Syntax Error Code", 50)]
    public string AK905 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Syntax Error Code", 60)]
    public string AK906 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Syntax Error Code", 70)]
    public string AK907 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Syntax Error Code", 80)]
    public string AK908 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Syntax Error Code", 90)]
    public string AK909 { get; set; }
}