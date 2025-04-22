using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(LM))]
[DataContract]
[Writable]
public class LM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Agency Qualifier Code", 10)]
    public string LM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Source Subqualifier", 20)]
    public string LM02 { get; set; }
}