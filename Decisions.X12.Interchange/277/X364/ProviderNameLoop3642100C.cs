using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract]
[Writable]
public class ProviderNameLoop3642100C // 2100C
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Provider Name", 10)]
    public NM1 NM1 { get; set; }
}