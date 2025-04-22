using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(TOO))]
[DataContract]
[Writable]
public class TOO
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Service ID Qualifier", 10)]
    public string TOO01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 20)]
    public string TOO02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface", 30)]
    public TOO03 TOO03 { get; set; }
}

[DataContract]
[Writable]
public class TOO03
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface code", 10)]
    public string TOO0301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface code", 20)]
    public string TOO0302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface code", 30)]
    public string TOO0303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface code", 40)]
    public string TOO0304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Tooth Surface code", 50)]
    public string TOO0305 { get; set; }
}