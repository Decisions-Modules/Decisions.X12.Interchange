using Decisions.X12.Hipaa.Common;
using System.Xml.Serialization;

namespace Decisions.X12.Hipaa.Claims;

public class SubmitterInfo
{
    public SubmitterInfo()
    {
        if (Providers == null) Providers = new Provider();
    }
    [XmlElement(ElementName = "Provider")]
    public Provider Providers { get; set; }
}
