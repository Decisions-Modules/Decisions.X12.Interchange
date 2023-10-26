﻿using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class HealthCoverageLoop
{
    [DataMember, WritableValue, PropertyClassification("Health Coverage", 10)]
    public HD834 HD { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Coverage Dates", 20)]
    public DTP834 DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Health Coverage Policy Number", 30)]
    public REF REF { get; set; }
}