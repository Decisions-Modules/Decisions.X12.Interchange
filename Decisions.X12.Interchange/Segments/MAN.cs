using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(MAN))]
[DataContract]
[Writable]
public class MAN
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Marks and Numbers Qualifier", 10)]
    public string MAN01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Marks and Numbers", 20)]
    public string MAN02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Marks and Numbers Qualifier 2", 30)]
    public string MAN03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Marks and Numbers 2", 40)]
    public string MAN04 { get; set; }
}
