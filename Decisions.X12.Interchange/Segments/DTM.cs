using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(DTM))]
[DataContract]
[Writable]
public class DTM
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("DateTime Qualifier", 10)]
    public string DTM01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 20)]
    public string DTM02 { get; set; }
}