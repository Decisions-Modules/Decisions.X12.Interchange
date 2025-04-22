using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(LQ))]
[DataContract]
[Writable]
public class LQ
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 10)]
    public string LQ01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string LQ02 { get; set; }
}