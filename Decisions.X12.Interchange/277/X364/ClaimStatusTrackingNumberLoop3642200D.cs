using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class ClaimStatusTrackingNumberLoop3642200D // 2200D
{
    [DataMember, WritableValue, PropertyClassification("Claim Status Tracking Number", 10)]
    public TRN TRN { get; set; }
    [XmlElement("STC")]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Secondary Information", 30)]
    [XmlElement("REF")]
    public REF[] REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Level Service Date", 40)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Line Information Loop", 50)]
    public ServiceLineLoop3642220D[] ServiceLineLoop3642220D { get; set; } // 2220D Loop

    internal List<ServiceLineLoop3642220D> ServiceLineLoop3642220DForDeserialize;
}