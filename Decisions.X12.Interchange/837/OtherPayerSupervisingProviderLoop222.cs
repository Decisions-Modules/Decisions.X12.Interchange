﻿using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class OtherPayerSupervisingProviderLoop222 // 2330F
{
    [DataMember, WritableValue, PropertyClassification("Name", 10)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Secondary Identification", 20)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
}