using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class AmbulanceDropoffLocationLoop222 // 2310F Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Name", 10)]
    public NM1 NM1 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Address", 20)]
    public N3 N3 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("City, State, Zip Code", 30)]
    public N4 N4 { get; set; }
}