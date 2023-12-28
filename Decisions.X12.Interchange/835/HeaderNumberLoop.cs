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
    [DataMember, WritableValue, PropertyClassification("Provider Summary Information", 20)]
    public TS3 TS3 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Provider Supplemental Summary Information", 30)]
    public TS2 TS2 { get; set; }
    [DataMember, WritableValue, PropertyClassification("Claim Payment Information Loop", 40)]
    public ClaimPaymentInformationLoop[] ClaimPaymentInformationLoop { get; set; } // 2100 Loop

    internal List<ClaimPaymentInformationLoop> ClaimPaymentInformationLoopForDeserialize;

}