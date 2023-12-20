using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class MEA
    {
        [DataMember, WritableValue, PropertyClassification("Measurement Reference ID Code", 10)]
        public string MEA01 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Measurement Qualifier", 20)]
        public string MEA02 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Measurement Value", 30)]
        public string MEA03 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Composite Unit of Measure", 40)]
        public MEA04 MEA04 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Range Minimum", 50)]
        public string MEA05 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Range Maximum", 60)]
        public string MEA06 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Measurement Significance Code", 70)]
        public string MEA07 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Measurement Attribute Code", 80)]
        public string MEA08 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Surface/Layer/Position Code", 90)]
        public string MEA09 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Measurement Method or Device", 100)]
        public string MEA10 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Code List Qualifier Code", 110)]
        public string MEA11 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Industry Code", 120)]
        public string MEA12 { get; set; }
    }

    [DataContract, Writable]
    public class MEA04
    {
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 10)]
        public string MEA0401 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 20)]
        public string MEA0402 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 30)]
        public string MEA0403 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 40)]
        public string MEA0404 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 50)]
        public string MEA0405 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 60)]
        public string MEA0406 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 70)]
        public string MEA0407 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 80)]
        public string MEA0408 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 90)]
        public string MEA0409 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 100)]
        public string MEA0410 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 110)]
        public string MEA0411 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 120)]
        public string MEA0412 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 130)]
        public string MEA0413 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 140)]
        public string MEA0414 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 150)]
        public string MEA0415 { get; set; }
    }
}
