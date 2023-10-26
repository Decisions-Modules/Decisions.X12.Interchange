using Decisions.X12.Attributes;

namespace Decisions.X12.Parsing.Model.Typed;

public enum RelationshipCode
{
    [EDIFieldValue("A")]
    Add,
    [EDIFieldValue("D")]
    Delete,
    [EDIFieldValue("I")]
    Include,
    [EDIFieldValue("O")]
    InformationOnly,
    [EDIFieldValue("S")]
    Substituted
}
