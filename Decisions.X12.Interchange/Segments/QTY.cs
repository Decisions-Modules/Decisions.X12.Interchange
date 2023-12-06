﻿using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class QTY
{
    [DataMember, WritableValue, PropertyClassification("Quantity Qualifier", 10)]
    public string QTY01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 20)]
    public string QTY02 { get; set; }
}