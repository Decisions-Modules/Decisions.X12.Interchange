using Decisions.X12.Attributes;

namespace Decisions.X12.Parsing.Model.Typed;

public enum YesNoConditionOrResponseCode
{
    [EDIFieldValue("N")]
    No,
    [EDIFieldValue("U")]
    Unknown,
    [EDIFieldValue("W")]
    NotApplicable,
    [EDIFieldValue("Y")]
    Yes
}
