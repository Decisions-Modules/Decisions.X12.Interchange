using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class Transaction824
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Beginning Segment", 20)]
    public BGN BGN { get; set; }
    [DataMember, WritableValue, PropertyClassification("N1 Loop", 30)]
    public N1Loop[] N1Loop { get; set; }
    [DataMember, WritableValue, PropertyClassification("OTI Loop", 40)]
    public OTILoop[] OTILoop { get; set; }
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 70)]
    public SE SE { get; set; }

    internal List<N1Loop> N1LoopForDeserialize;
    internal List<OTILoop> OTILoopForDeserialize;
}