using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PID))]
[DataContract]
[Writable]
public class PID
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Item Description Type", 10)]
    public string PID01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product/Process Characteristic Code", 20)]
    public string PID02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Agency Qualifier Code", 30)]
    public string PID03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Product Description Code", 40)]
    public string PID04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 50)]
    public string PID05 { get; set; }
}
