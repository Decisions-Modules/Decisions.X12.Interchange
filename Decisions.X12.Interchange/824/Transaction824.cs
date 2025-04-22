using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract]
[Writable]
public class Transaction824
{
    internal List<N1Loop> N1LoopForDeserialize;
    internal List<OTILoop> OTILoopForDeserialize;

    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Beginning Segment", 20)]
    public BGN BGN { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("N1 Loop", 30)]
    public N1Loop[] N1Loop { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("OTI Loop", 40)]
    public OTILoop[] OTILoop { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Transaction Set Trailer", 50)]
    public SE SE { get; set; }
}