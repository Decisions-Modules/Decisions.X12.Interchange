using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(HD))]
[DataContract]
[Writable]
public class HD
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Maintenance Type Code", 10)]
    public string HD01 { get; set; }
}