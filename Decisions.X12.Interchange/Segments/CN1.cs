using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class CN1
    {
        [DataMember, WritableValue, PropertyClassification("Contract Type Code", 10)]
        public string CN101 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Contract Amount", 20)]
        public string CN102 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Contract Percentage", 30)]
        public string CN103 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Contract Code", 40)]
        public string CN104 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Terms Discount Percent", 50)]
        public string CN105 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Contract Version Identifier", 60)]
        public string CN106 { get; set; }
    }
}
