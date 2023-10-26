using Decisions.X12.Attributes;

namespace Decisions.X12.Parsing.Model.Typed;

public enum AllowanceOrChargeIndicator
{
    [EDIFieldValue("A")]
    Allowance,
    [EDIFieldValue("C")]
    Charge,
    [EDIFieldValue("N")]
    NoAllowanceOrCharge,
    [EDIFieldValue("P")]
    Promotion,
    [EDIFieldValue("Q")]
    ChargeRequest,
    [EDIFieldValue("R")]
    AllowanceRequest,
    [EDIFieldValue("S")]
    Service
}
