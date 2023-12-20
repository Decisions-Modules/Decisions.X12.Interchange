using Decisions.X12.Interchange.Segments;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange837
{
    [DataContract, Writable]
    public class BillingProviderHierarchicalLevelLoop222 // 2000A
    {
        [DataMember, WritableValue, PropertyClassification("Hierarchical Level", 10)]
        public HL HL { get; set; }
        [DataMember, WritableValue, PropertyClassification("Speciality Information", 20)]
        public PRV PRV { get; set; }
        [DataMember, WritableValue, PropertyClassification("Currency Information", 30)]
        public CUR CUR { get; set; }
        
        //2010AA
        [DataMember, WritableValue, PropertyClassification("Provider Name Loop", 40)]
        public ProviderNameLoop222 ProviderNameLoop222 { get; set; }
        
        //2010AB
        [DataMember, WritableValue, PropertyClassification("Pay-To Address Loop", 50)]
        public PayToAddressLoop222 PayToAddressLoop222 { get; set; }
        //2010AC
        [DataMember, WritableValue, PropertyClassification("Pay-To Plan Loop", 60)]
        public PayToPlanLoop222 PayToPlanLoop222 { get; set; }
        
        //2000B
        [DataMember, WritableValue, PropertyClassification("Subscriber Loop", 70)]
        public SubscriberHierarchicalLevelLoop222[] SubscriberHierarchicalLevelLoop222 { get; set; }

        internal List<SubscriberHierarchicalLevelLoop222> SubscriberHierarchicalLevelLoop222ForDeserialize;
    }
}
