using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System.Runtime.Serialization;

namespace Decisions.X12.Interchange.Segments
{
    [DataContract, Writable]
    public class CLM
    {
        [DataMember, WritableValue, PropertyClassification("Claim Submitter's Identifier", 10)]
        public string CLM01 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Monetary Amount", 20)]
        public string CLM02 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Claim Filing Indicator Code", 30)]
        public string CLM03 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Non-Institutional Claim Type Code", 40)]
        public string CLM04 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Health Care Service Location Information", 50)]
        public CLM05 CLM05 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 60)]
        public string CLM06 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Provider Accept Assignment Code", 70)]
        public string CLM07 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 80)]
        public string CLM08 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Release of Information Code", 90)]
        public string CLM09 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Patient Signature Source Code", 100)]
        public string CLM10 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Related Causes Information", 110)]
        public CLM11 CLM11 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Special Program Code", 120)]
        public string CLM12 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 130)]
        public string CLM13 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Level of Service Code", 140)]
        public string CLM14 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 150)]
        public string CLM15 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Provider Agreement Code", 160)]
        public string CLM16 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Claim Status Code", 170)]
        public string CLM17 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Yes/No Condition or Response Code", 180)]
        public string CLM18 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Claim Submission Reason Code", 190)]
        public string CLM19 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Delay Reason Code", 200)]
        public string CLM20 { get; set; }

    }

    [DataContract, Writable]
    public class CLM05
    {
        [DataMember, WritableValue, PropertyClassification("Facility Code Value", 10)]  
        public string CLM0501 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Facility Code Qualifier", 20)]
        public string CLM0502 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Claim Frequency Type Code", 30)]
        public string CLM0503 { get; set; }
    }

    [DataContract, Writable]
    public class CLM11
    {
        [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 10)]
        public string CLM1101 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 20)]
        public string CLM1102 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Related-Causes Code", 30)]
        public string CLM1103 { get; set; }
        [DataMember, WritableValue, PropertyClassification("State or Province Code", 40)]
        public string CLM1104 { get; set; }
        [DataMember, WritableValue, PropertyClassification("Country Code", 50)]
        public string CLM1105 { get; set; }

    }
}
