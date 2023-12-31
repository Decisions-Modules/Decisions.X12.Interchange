﻿using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;

namespace X12Interchange834;

[DataContract, Writable]
public class MemberNameLoop
{
    [DataMember, WritableValue, PropertyClassification("Member Name", 10)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Communications Numbers", 20)]
    public PER PER { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence Street Address", 30)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Residence City, State, Zip", 40)]
    public N4 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Demographics", 50)]
    public DMG DMG { get; set; }
}
