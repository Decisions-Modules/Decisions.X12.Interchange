﻿using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class FunctionGroup835
{
    [DataMember, WritableValue, PropertyClassification("Functional Group Header", 10)]
    public GS GS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction", 20)]
    public Transaction835 Transaction { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group Trailer", 30)]
    public GE GE { get; set; }
}