using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class DrugIdentificationLoop222 // 2410 Loop
{
    [DataMember, WritableValue, PropertyClassification("Drug Identification", 10)]
    public LIN LIN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Drug Quantity", 20)]
    public CTP CTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Prescription or Compound Drug Association Number", 30)]
    public REF REF { get; set; }
}