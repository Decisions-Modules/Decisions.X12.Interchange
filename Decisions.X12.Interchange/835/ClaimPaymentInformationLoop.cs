using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class ClaimPaymentInformationLoop // 2100 Loop
{
    [DataMember, WritableValue, PropertyClassification("Claim Payment Information", 10)]
    [XmlElement("CLP", Order = 1)]
    public CLP CLP { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Adjustment", 20)]
    [XmlElement("CAS", Order = 2)]
    public CAS[] CAS { get; set; }
    [DataMember, WritableValue, PropertyClassification("Patient Name", 30)]
    [XmlElement("NM1", Order = 3)]
    public NM1 NM1PatientName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Insured Name", 40)]
    [XmlElement("NM1", Order = 4)]
    public NM1 NM1InsuredName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Corrected Name", 50)]
    [XmlElement("NM1", Order = 5)]
    public NM1 NM1CorrectedName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Name", 60)]
    [XmlElement("NM1", Order = 6)]
    public NM1 NM1ProviderName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Carrier Name", 70)]
    [XmlElement("NM1", Order = 7)]
    public NM1 NM1CarrierName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payer Name", 80)]
    [XmlElement("NM1", Order = 8)]
    public NM1 NM1PayerName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subscriber Name", 90)]
    [XmlElement("NM1", Order = 9)]
    public NM1 NM1SubscriberName { get; set; }
    [DataMember, WritableValue, PropertyClassification("Inpatient Adjudication Information", 100)]
    [XmlElement("MIA", Order = 10)]
    public MIA MIA { get; set; }
    [DataMember, WritableValue, PropertyClassification("Outpatient Adjudication Information", 110)]
    [XmlElement("MOA", Order = 11)]
    public MOA MOA { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Identification", 120)]
    [XmlElement("REF", Order = 12)]
    public REF[] REFClaimIdentification { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Identification", 130)]
    [XmlElement("REF", Order = 13)]
    public REF[] REFProviderIdentification { get; set; }
    [DataMember, WritableValue, PropertyClassification("Statement Date", 140)]
    [XmlElement("DTM", Order = 14)]
    public DTM[] DTMStatementDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Expiration Date", 150)]
    [XmlElement("DTM", Order = 15)]
    public DTM DTMExpirationDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Received Date", 160)]
    [XmlElement("DTM", Order = 16)]
    public DTM DTMReceivedDate { get; set; }
    [DataMember, WritableValue, PropertyClassification("Contact Information", 170)]
    [XmlElement("PER", Order = 17)]
    public PER[] PER { get; set; }
    [DataMember, WritableValue, PropertyClassification("Supplemental Information", 180)]
    [XmlElement("AMT", Order = 18)]
    public AMT[] AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("Supplemental Information Quantity", 190)]
    [XmlElement("QTY", Order = 19)]
    public QTY[] QTY { get; set; }
    [DataMember, WritableValue, PropertyClassification("Service Payment Information Loop", 200)]
    [XmlElement("Loop", Order = 20)]
    public ServicePaymentInformationLoop[] ServicePaymentInformationLoop { get; set; }// 2110 loop

    internal List<ServicePaymentInformationLoop> ServicePaymentInformationLoopForDeserialize;
}