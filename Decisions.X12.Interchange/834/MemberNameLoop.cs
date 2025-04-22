using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange834;

[DataContract]
[Writable]
public class MemberNameLoop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Name", 10)]
    public NM1 NM1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Communications Numbers", 20)]
    public PER PER { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Residence Street Address", 30)]
    public N3 N3 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Residence City, State, Zip", 40)]
    public N4 N4 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Member Demographics", 50)]
    public DMG DMG { get; set; }
}