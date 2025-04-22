using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class SponsorNameLoop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Sponsor Name", 10)]
    public N1 N1 { get; set; }
}