﻿using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using X12InterchangeFunctionalGroup;

namespace X12Interchange824;

[DataContract, Writable]
public class FunctionalGroup824
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Header", 10)]
    public GS GS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction", 20)]
    public Transaction824 Transaction { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Trailer", 30)]
    public GE GE { get; set; }
}