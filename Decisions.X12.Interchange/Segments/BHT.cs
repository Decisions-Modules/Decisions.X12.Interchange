using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class BHT
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Structure Code", 10)]
    public string BHT01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Purpose Code", 20)]
    public string BHT02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string BHT03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 40)]
    public string BHT04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Time", 50)]
    public string BHT05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Type Code", 50)]
    public string BHT06 { get; set; }
}