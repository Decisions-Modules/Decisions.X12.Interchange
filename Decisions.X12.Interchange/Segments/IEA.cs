﻿using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class IEA
{
    [DataMember, WritableValue, PropertyClassification("Number of Included Functional Groups", 10)]
    public string IEA01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Number", 20)]
    public string IEA02 { get; set; }
}
