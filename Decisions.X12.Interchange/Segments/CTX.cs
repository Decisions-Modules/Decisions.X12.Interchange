using System.Runtime.Serialization;
using Decisions.X12.Attributes;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[EdiSegment(nameof(CTX))]
[DataContract]
[Writable]
public class CTX
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Context Identification", 10)]
    public CTX01 CTX01 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Segment ID Code", 20)]
    public string CTX02 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Segment Position in Transaction Set", 30)]
    public string CTX03 { get; set; }

    [EdiElement(3)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Loop Identifier Code", 40)]
    public string CTX04 { get; set; }

    [EdiElement(4)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Position in Segment", 50)]
    public CTX05 CTX05 { get; set; }

    [EdiElement(5)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Reference in Segment", 60)]
    public CTX06 CTX06 { get; set; }
}

[DataContract]
[Writable]
public class CTX01
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Context Name", 10)]
    public string CTX0101 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Context Reference", 20)]
    public string CTX0102 { get; set; }
}

[DataContract]
[Writable]
public class CTX05
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Element Position in Segment", 10)]
    public string CTX0501 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Component Data Element Position in Composite", 20)]
    public string CTX0502 { get; set; }

    [EdiElement(2)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Repeating Data Element Position", 30)]
    public string CTX0503 { get; set; }
}

[DataContract]
[Writable]
public class CTX06
{
    [EdiElement(0)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Reference Number", 10)]
    public string CTX0601 { get; set; }

    [EdiElement(1)]
    [DataMember]
    [WritableValue]
    [PropertyClassification("Data Element Reference Number", 20)]
    public string CTX0602 { get; set; }
}