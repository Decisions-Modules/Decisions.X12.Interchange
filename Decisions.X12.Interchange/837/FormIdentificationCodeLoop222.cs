using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class FormIdentificationCodeLoop222 // 2440 Loop
{
    [DataMember, WritableValue, PropertyClassification("Form Identification Code", 10)]
    public LQ LQ { get; set; }
    [DataMember, WritableValue, PropertyClassification("Supporting Documentation", 20)]
    public FRM FRM { get; set; }
}