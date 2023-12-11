using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class TRN
{
    [DataMember, WritableValue, PropertyClassification("Trace Type Code", 10)]
    public string TRN01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string TRN02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Originating Company Identifier", 30)]
    public string TRN03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 40)]
    public string TRN04 { get; set; }
}