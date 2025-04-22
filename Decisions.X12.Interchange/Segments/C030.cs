using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace Decisions.X12.Interchange.Segments;

[DataContract, Writable]
public class C030
{
    [DataMember, WritableValue, PropertyClassification("Element Position in Segment", 10)]  
    public string C03001 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Component Data Element Position in Composite", 20)]
    public string C03002 { get; set; }

    [DataMember, WritableValue, PropertyClassification("Repeating Data Element Position", 30)]
    public string C03003 { get; set; }
}