using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277;

[DataContract, Writable]
public class ClaimSubmitterTraceNumberLoop364 // 2200A
{
    [DataMember, WritableValue, PropertyClassification("Transmission Receipt Control Identifier", 10)]
    public TRN TRN { get; set; }
    
    [XmlElement("DTP")]
    [DataMember, WritableValue, PropertyClassification("Information Source Receipt Date", 20)]
    public DTP[] DTP { get; set; }
}