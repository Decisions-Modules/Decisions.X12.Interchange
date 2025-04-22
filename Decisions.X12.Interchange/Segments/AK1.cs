using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(AK1))]
[DataContract]
[Writable]
public class AK1
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Functional Identifier Code", 10)]
    public string AK101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Group Control Number", 20)]
    public string AK102 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Version / Release / Industry Identifier Code", 30)]
    public string AK103 { get; set; }
}