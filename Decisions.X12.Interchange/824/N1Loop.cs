using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using X12Interchange834;

namespace X12Interchange824;

[DataContract, Writable]
public class N1Loop
{
    [DataMember, WritableValue, PropertyClassification("Name", 10)]
    public N1 N1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Name Information", 20)]
    public N2 N2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence Street Address", 30)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence City, State, Zip", 40)]
    public N4 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Information", 50)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Communications Numbers", 60)]
    public PER PER { get; set; }
}