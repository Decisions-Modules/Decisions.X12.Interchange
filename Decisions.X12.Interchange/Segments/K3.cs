using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Decisions.X12.Interchange.Segments
{
    public class K3
    {
        [DataMember, WritableValue, PropertyClassification("Fixed Format Information", 10)]
        public string K301 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Record Format Code", 20)]
        public string K302 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Composite Unit of Measure", 30)]
        public K303 K303 { get; set; }

    }

    public class K303
    {
        [DataMember, WritableValue, PropertyClassification("Unit for Measurement Code", 10)]
        public string K30301 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 20)]
        public string K30302 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 30)]
        public string K30303 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit or Basis for Measurement Code", 40)]
        public string K30304 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 50)]
        public string K30305 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 60)]
        public string K30306 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit or Basis for Measurement Code", 70)]
        public string K30307 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 80)]
        public string K30308 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 90)]
        public string K30309 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit or Basis for Measurement Code", 100)]
        public string K30310 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 110)]
        public string K30311 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 120)]
        public string K30312 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Unit or Basis for Measurement Code", 130)]
        public string K30313 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Exponent", 140)]
        public string K30314 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Multiplier", 150)]
        public string K30315 { get; set; }
    }
}
