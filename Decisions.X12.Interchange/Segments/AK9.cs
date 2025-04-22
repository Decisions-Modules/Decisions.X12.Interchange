using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(AK9))]
[DataContract]
[Writable]
public class AK9
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Acknowledge Code", 10)]
    public string AK901 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Transaction Sets Included", 20)]
    public string AK902 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Received Transaction Sets", 30)]
    public string AK903 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Number of Accepted Transaction Sets", 40)]
    public string AK904 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Syntax Error Code", 50)]
    public string AK905 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Syntax Error Code", 60)]
    public string AK906 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Syntax Error Code", 70)]
    public string AK907 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Syntax Error Code", 80)]
    public string AK908 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Group Syntax Error Code", 90)]
    public string AK909 { get; set; }
}