using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837;

[DataContract]
[Writable]
public class LineAdjudicationInformationLoop222 // 2430 Loop
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Adjudication Information", 10)]
    public SVD SVD { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Adjudication", 20)]
    [XmlElement("CAS")]
    public CAS[] CAS { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Line Check or Remittance Date", 30)]
    public DTP DTP { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Remaining Patient Liability", 40)]
    public AMT AMT { get; set; }
}