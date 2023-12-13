using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class PRV
{
    [DataMember, WritableValue, PropertyClassification("Provider Code", 10)]
    public string PRV01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification Qualifier", 20)]
    public string PRV02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 30)]
    public string PRV03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("State or Province Code", 40)]
    public string PRV04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Specialty Information", 50)]
    public PRV05 PRV05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Organization Code", 60)]
    public string PRV06 { get; set; }
}

[DataContract, Writable]
public class PRV05
{
    [DataMember, WritableValue, PropertyClassification("Provider Specialty Code", 10)]
    public string PRV0501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Agency Qualifier Code", 20)]
    public string PRV0502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 30)]
    public string PRV0503 { get; set; }
}