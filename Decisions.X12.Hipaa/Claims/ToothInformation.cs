using System.Xml.Serialization;

namespace Decisions.X12.Hipaa.Claims;

public class ToothInformation
{
    [XmlAttribute]
    public string ToothCode { get; set; }

    [XmlElement(ElementName = "ToothSurface")]
    public List<Common.Lookup> ToothSurfaces { get; set; }
}
