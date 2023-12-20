using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class CR3
    {
        [DataMember, WritableValue, PropertyClassification("Certification Type Code", 10)]
        public string CR301 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 20)]
        public string CR302 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Quantity", 30)]
        public string CR303 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Insuline Dependent Code", 40)]
        public string CR304 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Description", 50)]
        public string CR305 { get; set; }
    }
}
