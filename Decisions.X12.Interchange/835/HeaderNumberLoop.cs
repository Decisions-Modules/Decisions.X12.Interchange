using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange835;

[DataContract, Writable]
public class HeaderNumberLoop // 2000 Loop
{
    [DataMember, WritableValue, PropertyClassification("Header Number", 10)]
    public LX LX { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Payment Information Loop", 20)]
    public ClaimPaymentInformationLoop[] ClaimPaymentInformationLoop { get; set; } // 2100 Loop

    internal List<ClaimPaymentInformationLoop> ClaimPaymentInformationLoopForDeserialize;

}