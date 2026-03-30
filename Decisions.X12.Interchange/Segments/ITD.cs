using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(ITD))]
[DataContract]
[Writable]
public class ITD
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Type Code", 10)]
    public string ITD01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Basis Date Code", 20)]
    public string ITD02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Discount Percent", 30)]
    public string ITD03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Discount Due Date", 40)]
    public string ITD04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Discount Days Due", 50)]
    public string ITD05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Net Due Date", 60)]
    public string ITD06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Net Days", 70)]
    public string ITD07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Terms Discount Amount", 80)]
    public string ITD08 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Description", 120)]
    public string ITD12 { get; set; }
}
