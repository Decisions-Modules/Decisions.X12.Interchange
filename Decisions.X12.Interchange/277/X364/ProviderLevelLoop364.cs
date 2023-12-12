using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ProviderLevelLoop364 // 2000C Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Name Loop", 20)]
    public PayerNameLoop364 ProviderNameLoop { get; set; } // 2100C Loop
    [DataMember, WritableValue, PropertyClassification("Provider Trace Loop", 30)]
    public ProviderTraceLoop364 ProviderTraceLoop364 { get; set; } //2200C Loop
    [DataMember, WritableValue, PropertyClassification("Patient Level Loop", 40)]
    public PatientLevelLoop364[] PatientLevelLoop364 { get; set; } // 2000D Loop

    internal List<PatientLevelLoop364> PatientLevelLoop364ForDeserialize;
}