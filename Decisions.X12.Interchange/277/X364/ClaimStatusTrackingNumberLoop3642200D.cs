using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract]
[Writable]
public class ClaimStatusTrackingNumberLoop3642200D // 2200D
{
    internal List<ServiceLineLoop3642220D> ServiceLineLoop3642220DForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Status Tracking Number", 10)]
    public TRN TRN { get; set; }

    [XmlElement("STC")]
    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Secondary Information", 30)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Level Service Date", 40)]
    public DTP DTP { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service Line Information Loop", 50)]
    public ServiceLineLoop3642220D[] ServiceLineLoop3642220D { get; set; } // 2220D Loop
}