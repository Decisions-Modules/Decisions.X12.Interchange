using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ProviderLevelLoop3642000C // 2000C Loop
{
    [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
    public HL HL { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Name Loop", 20)]
    public ProviderNameLoop3642100C ProviderNameLoop3642100C { get; set; } // 2100C Loop
    [DataMember, WritableValue, PropertyClassification("Provider Trace Loop", 30)]
    public ProviderTraceLoop3642200C ProviderTraceLoop3642200C { get; set; } //2200C Loop
    [DataMember, WritableValue, PropertyClassification("Patient Level Loop", 40)]
    public PatientLevelLoop3642000D[] PatientLevelLoop3642000D { get; set; } // 2000D Loop

    internal List<PatientLevelLoop3642000D> PatientLevelLoop3642000DForDeserialize;
}