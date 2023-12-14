using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class Transaction835
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Financial Information", 20)]
    public BPR BPR { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reassociation Trace Number", 30)]
    public TRN TRN { get; set; }
    [DataMember, WritableValue, PropertyClassification("Receiver Identification", 50)]
    public REF REF { get; set; }
    [DataMember, WritableValue, PropertyClassification("Production Date", 60)]
    public DTM DTM { get; set; }
    [DataMember, WritableValue, PropertyClassification("Payer Identification Loop", 70)]
    public PayerIdentificationLoop PayerIdentificationLoop { get; set; }// 1000A Loop
    [DataMember, WritableValue, PropertyClassification("Payee Identification Loop", 80)]
    public PayeeIdentificationLoop PayeeIdentificationLoop { get; set; }// 1000B Loop
    [DataMember, WritableValue, PropertyClassification("Header Number Loop", 90)]
    public HeaderNumberLoop[] HeaderNumberLoop { get; set; } //2000 Loop
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 110)]
    public SE SE { get; set; }

    internal List<HeaderNumberLoop> HeaderNumberLoopForDeserialize;
}