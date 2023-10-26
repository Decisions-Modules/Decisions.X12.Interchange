using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class MemberNameLoop
{
    [DataMember, WritableValue, PropertyClassification("Member Name", 10)]
    public NM1834 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Communications Numbers", 20)]
    public PER834 PER { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence Street Address", 30)]
    public N3834 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence City, State, Zip", 40)]
    public N4834 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Demographics", 50)]
    public DMG834 DMG { get; set; }
}
