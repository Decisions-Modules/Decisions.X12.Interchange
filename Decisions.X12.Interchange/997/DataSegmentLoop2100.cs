using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange997;

[DataContract]
[Writable]
public class DataSegmentLoop2100
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Segment Note", 10)]
    public AK3 AK3 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Note", 10)]
    public AK4 AK4 { get; set; }
}