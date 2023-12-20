using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class FRM
{
    [DataMember, WritableValue, PropertyClassification("Assigned Identification", 10)]
    public string FRM01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Response Code", 20)]
    public string FRM02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string FRM03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 40)]
    public string FRM04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Percent, Decimal Format", 50)]
    public string FRM05 { get; set; }
}