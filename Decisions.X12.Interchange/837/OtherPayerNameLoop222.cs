﻿using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract, Writable]
public class OtherPayerNameLoop222 // 2330B Loop
{
    [DataMember, WritableValue, PropertyClassification("Name", 10)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Address", 20)]
    public N3 N3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("City, State, Zip Code", 30)]
    public N4 N4 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Check or Remittance Date", 40)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Additional Information", 50)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
}