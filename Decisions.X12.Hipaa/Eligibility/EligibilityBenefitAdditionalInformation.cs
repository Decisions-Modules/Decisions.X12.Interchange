﻿using System.Xml.Serialization;

namespace Decisions.X12.Hipaa.Eligibility;

public class EligibilityBenefitAdditionalInformation
{
    [XmlAttribute]
    public string Qualifier { get; set; }
    [XmlAttribute]
    public string IndustryCode { get; set; }
    [XmlAttribute]
    public string CodeCategory { get; set; }

    [XmlText]
    public string Text { get; set; }
}
