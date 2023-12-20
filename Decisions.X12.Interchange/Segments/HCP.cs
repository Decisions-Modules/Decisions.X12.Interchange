using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class HCP
    {
        [DataMember, WritableValue, PropertyClassification("Pricing Methodology", 10)]
        public string HCP01 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
        public string HCP02 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Monetary Amount", 30)]
        public string HCP03 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Reference Identification", 40)]
        public string HCP04 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Rate", 50)]
        public string HCP05 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Reference Idenification", 60)]
        public string HCP06 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Monetary Amount", 70)]
        public string HCP07 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Service ID", 80)]
        public string HCP08 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Service ID Qualifier", 90)]
        public string HCP09 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Service ID", 100)]
        public string HCP10 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 110)]
        public string HCP11 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Quantity", 120)]
        public string HCP12 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Reject Reason Code", 130)]
        public string HCP13 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Policy Compliance Code", 140)]
        public string HCP14 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exception Code", 150)]
        public string HCP15 { get; set; }
    }
}
