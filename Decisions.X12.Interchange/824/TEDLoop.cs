﻿using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class TEDLoop
{
    [DataMember, WritableValue, PropertyClassification("Technical Error Description", 10)]
    public TED TED { get; set; }
    
    [XmlElement("CTX")]
    [DataMember, WritableValue, PropertyClassification("Context", 20)]
    public CTX[] CTX { get; set; }
    
    [XmlElement("NTE")]
    [DataMember, WritableValue, PropertyClassification("Note/Special Instruction", 30)]
    public NTE[] NTE { get; set; }
    
    [XmlElement("RED")]
    [DataMember, WritableValue, PropertyClassification("Related Data", 40)]
    public RED[] RED { get; set; }
}