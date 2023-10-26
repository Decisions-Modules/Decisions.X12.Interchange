using System.Xml.Serialization;

namespace Decisions.X12.Hipaa.ClaimStatus;

public class ClaimStatusResponse : ClaimStatusBase
{
    public ClaimStatusResponse()
    {
        if (ServiceLineResponses == null) ServiceLineResponses = new List<ClaimStatusServiceLineResponse>();
    }

    [XmlElement(ElementName = "ServiceLineResponse")]
    public List<ClaimStatusServiceLineResponse> ServiceLineResponses { get; set; }
}
