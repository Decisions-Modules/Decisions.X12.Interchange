using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange824;

[DataContract, Writable]
public class LMLoop
{
    [DataMember, WritableValue, PropertyClassification("Code Source Information", 10)]
    public LM LM { get; set; }
    [DataMember, WritableValue, PropertyClassification("LQ Loop", 20)]
    public LQLoop[] LQLoop { get; set; }

    internal List<LQLoop> LQLoopForDeserialize;
}