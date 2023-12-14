using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class PLB
{
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 10)]
    public string PLB01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Date", 20)]
    public string PLB02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 30)]
    public PLB03 PLB03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 40)]
    public string PLB04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 50)]
    public PLB05 PLB05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 60)]
    public string PLB06 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 70)]
    public PLB07 PLB07 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 80)]
    public string PLB08 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 90)]
    public PLB09 PLB09 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 100)]
    public string PLB10 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 110)]
    public PLB11 PLB11 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 120)]
    public string PLB12 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Adjustment Identifier", 130)]
    public PLB13 PLB13 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 140)]
    public string PLB14 { get; set; }
}

[DataContract, Writable]
public class PLB03
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB0302 { get; set; }
}

[DataContract, Writable]
public class PLB05
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0501 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB0502 { get; set; }
}

[DataContract, Writable]
public class PLB07
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0701 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB0702 { get; set; }
}

[DataContract, Writable]
public class PLB09
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0901 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB0902 { get; set; }
}

[DataContract, Writable]
public class PLB11
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB1101 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB1102 { get; set; }
}

[DataContract, Writable]
public class PLB13
{
    [DataMember, WritableValue, PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB1301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Reference Identification", 20)]
    public string PLB1302 { get; set; }
}