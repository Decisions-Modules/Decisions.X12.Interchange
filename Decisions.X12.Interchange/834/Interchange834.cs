﻿using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using X12InterchangeCommon;

namespace X12Interchange834;

[DataContract, Writable]
public class Interchange834
{
    [DataMember, WritableValue, PropertyClassification("Segment Terminator", 1)]
    [XmlAttribute("segment-terminator")]
    public string SegmentTerminator { get; set; }
    [DataMember, WritableValue, PropertyClassification("Element Separator", 2)]
    [XmlAttribute("element-separator")]
    public string ElementSeparator { get; set; }
    [DataMember, WritableValue, PropertyClassification("Sub Element Separator", 3)]
    [XmlAttribute("sub-element-separator")]
    public string SubElementSeparator { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Header", 10)]
    public ISA ISA { get; set; }
    [DataMember, WritableValue, PropertyClassification("Functional Group", 20)]
    public FunctionalGroup834 FunctionGroup { get; set; }
    [DataMember, WritableValue, PropertyClassification("Interchange Control Trailer", 30)]
    public IEA IEA { get; set; }
}