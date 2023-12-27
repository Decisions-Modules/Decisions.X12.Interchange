using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class PatientNameLoop3642100D // 2100D
{
    [DataMember, WritableValue, PropertyClassification("Patient Name", 10)]
    public NM1 NM1 { get; set; }
}