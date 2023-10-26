using System.Xml.Serialization;

namespace Decisions.X12.Parsing.Specification;

public class AllowedIdentifier
{
    [XmlAttribute]
    public string ID { get; set; }

    [XmlText]
    public string Description { get; set; }
}
