using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using X12Interchange834;

namespace X12Interchange824;

[DataContract, Writable]
public class OTILoop
{
    [DataMember, WritableValue, PropertyClassification("Original Transaction Identification", 10)]
    public OTI OTI { get; set; }
    [DataMember, WritableValue, PropertyClassification("Subscriber or Member Number", 20)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date and Time Qualifiers", 30)]
    public DTM DTM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount Information", 40)]
    public AMT AMT { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity Information", 50)]
    public QTY QTY { get; set; }
    [DataMember, WritableValue, PropertyClassification("Member Name", 60)]
    public NM1 NM1 { get; set; }
    [DataMember, WritableValue, PropertyClassification("TED Loop", 70)]
    public TEDLoop[] TEDLoop { get; set; }

    internal List<TEDLoop> TEDLoopForDeserialize;
}