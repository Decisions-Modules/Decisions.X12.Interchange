using Decisions.X12.Hipaa.Common;
using System.Xml.Serialization;

namespace Decisions.X12.Hipaa.Claims;

public class DrugIdentification
{
    [XmlAttribute]
    public string Ndc { get; set; }

    [XmlAttribute]
    public decimal Quantity { get; set; }

    public Lookup UnitOfMeasure { get; set; }

    public Identification Identification { get; set; }
}
