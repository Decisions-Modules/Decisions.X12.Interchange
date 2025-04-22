using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(MEA))]
[DataContract]
[Writable]
public class MEA
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Reference ID Code", 10)]
    public string MEA01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Qualifier", 20)]
    public string MEA02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Value", 30)]
    public string MEA03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Unit of Measure", 40)]
    public MEA04 MEA04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Range Minimum", 50)]
    public string MEA05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Range Maximum", 60)]
    public string MEA06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Significance Code", 70)]
    public string MEA07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Attribute Code", 80)]
    public string MEA08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Surface/Layer/Position Code", 90)]
    public string MEA09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Measurement Method or Device", 100)]
    public string MEA10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Code List Qualifier Code", 110)]
    public string MEA11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Industry Code", 120)]
    public string MEA12 { get; set; }
}

[DataContract]
[Writable]
public class MEA04
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 10)]
    public string MEA0401 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 20)]
    public string MEA0402 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 30)]
    public string MEA0403 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 40)]
    public string MEA0404 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 50)]
    public string MEA0405 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 60)]
    public string MEA0406 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 70)]
    public string MEA0407 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 80)]
    public string MEA0408 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 90)]
    public string MEA0409 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 100)]
    public string MEA0410 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 110)]
    public string MEA0411 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 120)]
    public string MEA0412 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 130)]
    public string MEA0413 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 140)]
    public string MEA0414 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 150)]
    public string MEA0415 { get; set; }
}