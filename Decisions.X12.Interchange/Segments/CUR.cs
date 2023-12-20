using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class CUR
    {
        [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 10)]
        public string CUR01 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Currency Code", 20)]
        public string CUR02 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exchange Rate", 30)]
        public string CUR03 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Entity Identifier Code", 40)]
        public string CUR04 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Currency Code", 50)]
        public string CUR05 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Currency Market/Exchange Code", 60)]
        public string CUR06 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date/Time Qualifier", 70)]
        public string CUR07 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date", 80)]
        public string CUR08 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Time", 90)]
        public string CUR09 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date/Time Qualifier", 100)]
        public string CUR10 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date", 110)]
        public string CUR11 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Time", 120)]
        public string CUR12 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date/Time Qualifier", 130)]
        public string CUR13 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date", 140)]
        public string CUR14 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Time", 150)]
        public string CUR15 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date/Time Qualifier", 160)]
        public string CUR16 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date", 170)]
        public string CUR17 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Time", 180)]
        public string CUR18 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date/Time Qualifier", 190)]
        public string CUR19 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Date", 200)]
        public string CUR20 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Time", 210)]
        public string CUR21 { get; set; }
    }
}
