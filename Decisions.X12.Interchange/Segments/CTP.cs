using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class CTP
{
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 10)]
    public string CTP01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Price Identifier Code", 20)]
    public string CTP02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit Price", 30)]
    public string CTP03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 40)]
    public string CTP04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Composite Unit of Measure", 50)]
    public CTP05 CTP05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Price Multiplier Qualifier", 60)]
    public string CTP06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 70)]
    public string CTP07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string CTP08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Basis of Unit Price Code", 90)]
    public string CTP09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Condition Value", 100)]
    public string CTP10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiple Price Quantity", 110)]
    public string CTP11 { get; set; }
}

[DataContract, Writable]
public class CTP05
{
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 10)]
    public string CTP0501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Exponent", 20)]
    public string CTP0502 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 30)]
    public string CTP0503 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 40)]
    public string CTP0504 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Exponent", 50)]
    public string CTP0505 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 60)]
    public string CTP0506 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 70)]
    public string CTP0507 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Exponent", 80)]
    public string CTP0508 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 90)]
    public string CTP0509 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 100)]
    public string CTP0510 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Exponent", 110)]
    public string CTP0511 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 120)]
    public string CTP0512 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 130)]
    public string CTP0513 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Exponent", 140)]
    public string CTP0514 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Multiplier", 150)]
    public string CTP0515 { get; set; }
}