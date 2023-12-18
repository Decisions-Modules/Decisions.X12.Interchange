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
    internal class OI
    {
        [DataMember, WritableValue, PropertyClassification("Claim Filing Indicator Code", 10)]
        public string OI01 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Claim Submission Reason Code", 20)]
        public string OI02 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Response Code", 30)]
        public string OI03 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Patient Signature Source Code", 40)]
        public string OI04 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Provider Agreement Code", 50)]
        public string OI05 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Release of Information Code", 60)]
        public string OI06 { get; set; }
    }
}
