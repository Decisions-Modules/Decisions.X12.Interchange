﻿using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace X12Interchange834;

[DataContract, Writable]
public class PER834
{
    [DataMember, WritableValue, PropertyClassification("Contact Function Code", 10)]
    public string PER01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Name", 20)]
    public string PER02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Communication Number Qualifier", 30)]
    public string PER03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Communication Number", 40)]
    public string PER04 { get; set; }
}