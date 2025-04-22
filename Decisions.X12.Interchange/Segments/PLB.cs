using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(PLB))]
[DataContract]
[Writable]
public class PLB
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 10)]
    public string PLB01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Date", 20)]
    public string PLB02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 30)]
    public PLB03 PLB03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 40)]
    public string PLB04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 50)]
    public PLB05 PLB05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 60)]
    public string PLB06 { get; set; }

    [EdiElement(6)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 70)]
    public PLB07 PLB07 { get; set; }

    [EdiElement(7)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 80)]
    public string PLB08 { get; set; }

    [EdiElement(8)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 90)]
    public PLB09 PLB09 { get; set; }

    [EdiElement(9)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 100)]
    public string PLB10 { get; set; }

    [EdiElement(10)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 110)]
    public PLB11 PLB11 { get; set; }

    [EdiElement(11)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 120)]
    public string PLB12 { get; set; }

    [EdiElement(12)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Identifier", 130)]
    public PLB13 PLB13 { get; set; }

    [EdiElement(13)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Monetary Amount", 140)]
    public string PLB14 { get; set; }
}

[DataContract]
[Writable]
public class PLB03
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB0302 { get; set; }
}

[DataContract]
[Writable]
public class PLB05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB0502 { get; set; }
}

[DataContract]
[Writable]
public class PLB07
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0701 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB0702 { get; set; }
}

[DataContract]
[Writable]
public class PLB09
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB0901 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB0902 { get; set; }
}

[DataContract]
[Writable]
public class PLB11
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB1101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB1102 { get; set; }
}

[DataContract]
[Writable]
public class PLB13
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Adjustment Reason Code", 10)]
    public string PLB1301 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference Identification", 20)]
    public string PLB1302 { get; set; }
}