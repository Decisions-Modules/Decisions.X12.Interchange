using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract]
[Writable]
public class ReceiverNameLoop3642100B // 2100B
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Information Receiver Name", 10)]
    public NM1 NM1 { get; set; }
}