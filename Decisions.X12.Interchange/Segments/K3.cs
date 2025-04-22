using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(K3))]
[DataContract]
[Writable]
public class K3
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Fixed Format Information", 10)]
    public string K301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Record Format Code", 20)]
    public string K302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Unit of Measure", 30)]
    public K303 K303 { get; set; }
}

[EdiSegment(nameof(K303))]
[DataContract]
[Writable]
public class K303
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 10)]
    public string K30301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 20)]
    public string K30302 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 30)]
    public string K30303 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit or Basis for Measurement Code", 40)]
    public string K30304 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 50)]
    public string K30305 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 60)]
    public string K30306 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit or Basis for Measurement Code", 70)]
    public string K30307 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 80)]
    public string K30308 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 90)]
    public string K30309 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit or Basis for Measurement Code", 100)]
    public string K30310 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 110)]
    public string K30311 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 120)]
    public string K30312 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit or Basis for Measurement Code", 130)]
    public string K30313 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 140)]
    public string K30314 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 150)]
    public string K30315 { get; set; }
}