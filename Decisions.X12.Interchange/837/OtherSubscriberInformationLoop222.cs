using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class OtherSubscriberInformationLoop222 // 2320 Loop
{
    internal List<OtherPayerReferringProviderLoop222> OtherPayerReferringProviderLoop222ForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Subscriber Information", 10)]
    public SBR SBR { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Claim Level Adjustments", 20)]
    [XmlElement("CAS")]
    public CAS[] CAS { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Amounts", 30)]
    [XmlElement("AMT")]
    public AMT[] AMT { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Insurance Coverage Information", 40)]
    public OI OI { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Outpatient Adjudication Information", 50)]
    public MOA MOA { get; set; }

    // Loop 2330A
    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Subscriber Name Loop", 60)]
    public OtherSubscriberNameLoop222 OtherSubscriberNameLoop222 { get; set; }

    // Loop 2330B
    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Name Loop", 70)]
    public OtherPayerNameLoop222 OtherPayerNameLoop222 { get; set; }

    // Loop 2330C
    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Referring Provider Loop", 80)]
    public OtherPayerReferringProviderLoop222[] OtherPayerReferringProviderLoop222 { get; set; }

    // Loop 2330D
    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Rendering Provider Loop", 90)]
    public OtherPayerRenderingProviderLoop222 OtherPayerRenderingProviderLoop222 { get; set; }

    // Loop 2330E
    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Service Facility Location Loop", 100)]
    public OtherPayerServiceFacilityLocationLoop222 OtherPayerServiceFacilityLocationLoop222 { get; set; }

    // Loop 2330F
    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Supervising Provider Loop", 110)]
    public OtherPayerSupervisingProviderLoop222 OtherPayerSupervisingProviderLoop222 { get; set; }

    // Loop 2330G
    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Other Payer Billing Provider Loop", 120)]
    public OtherPayerBillingProviderLoop222 OtherPayerBillingProviderLoop222 { get; set; }
}