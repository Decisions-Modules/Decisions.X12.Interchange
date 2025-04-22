using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CTP))]
[DataContract]
[Writable]
public class CTP
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 10)]
    public string CTP01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Price Identifier Code", 20)]
    public string CTP02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit Price", 30)]
    public string CTP03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Quantity", 40)]
    public string CTP04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Composite Unit of Measure", 50)]
    public CTP05 CTP05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Price Multiplier Qualifier", 60)]
    public string CTP06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 70)]
    public string CTP07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 80)]
    public string CTP08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Basis of Unit Price Code", 90)]
    public string CTP09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Condition Value", 100)]
    public string CTP10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiple Price Quantity", 110)]
    public string CTP11 { get; set; }
}

[DataContract]
[Writable]
public class CTP05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 10)]
    public string CTP0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 20)]
    public string CTP0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 30)]
    public string CTP0503 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 40)]
    public string CTP0504 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 50)]
    public string CTP0505 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 60)]
    public string CTP0506 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 70)]
    public string CTP0507 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 80)]
    public string CTP0508 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 90)]
    public string CTP0509 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 100)]
    public string CTP0510 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 110)]
    public string CTP0511 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 120)]
    public string CTP0512 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Unit for Measurement Code", 130)]
    public string CTP0513 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Exponent", 140)]
    public string CTP0514 { get; set; }

    [EdiElement(14)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Multiplier", 150)]
    public string CTP0515 { get; set; }
}