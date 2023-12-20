using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class SVD
{
    [DataMember, WritableValue, PropertyClassification("Identification Code", 10)]
    public string SVD01 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
    public string SVD02 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Composite Medical Procedure Identifier", 30)]
    public SVD03 SVD03 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 40)]
    public string SVD04 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Quantity", 50)]
    public string SVD05 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Assigned Number", 60)]
    public string SVD06 { get; set; }
}

[DataContract, Writable]
public class SVD03
{
    [DataMember, WritableValue, PropertyClassification("Product/Service ID Qualifier", 10)]
    public string SVD0301 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 20)]
    public string SVD0302 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 30)]
    public string SVD0303 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 40)]
    public string SVD0304 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 50)]
    public string SVD0305 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Procedure Modifier", 60)]
    public string SVD0306 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Description", 70)]
    public string SVD0307 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Product/Service ID", 80)]
    public string SVD0308 { get; set; }
}