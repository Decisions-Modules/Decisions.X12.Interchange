using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277;

[DataContract, Writable]
public class ClaimLevelTrackingNumberLoop364 // 2200D
{
    [DataMember, WritableValue, PropertyClassification("Claim Status Tracking Number", 10)]
    [XmlElement("TRN", Order = 1)]
    public TRN TRN { get; set; }
    [XmlElement("STC", Order = 2)]
    [DataMember, WritableValue, PropertyClassification("Status Information", 20)]
    public STC[] STC { get; set; }
    [DataMember, WritableValue, PropertyClassification("Data Receiver Claim Control Number", 30)]
    [XmlElement("REF", Order = 3)]
    public REF REFReceiverClaimControlNumber { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payer Claim Control Number", 40)]
    [XmlElement("REF", Order = 4)]
    public REF REFPayerClaimControlNumber { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Identifier For Transmission Intermediaries", 50)]
    [XmlElement("REF", Order = 5)]
    public REF REFClaimIdentifierTransmissionIntermediaries { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Level Service Date", 60)]
    [XmlElement("DTP", Order = 6)]
    public DTP DTP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Line Information Loop", 70)]
    [XmlElement("Loop", Order = 7)]
    public ServiceLineLoop364[] ServiceLineLoop364 { get; set; } //2220D Loop
}