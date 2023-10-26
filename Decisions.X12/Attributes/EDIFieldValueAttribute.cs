namespace Decisions.X12.Attributes;

public class EDIFieldValueAttribute : Attribute
{
    public string Value { get; private set; }
    public EDIFieldValueAttribute(string value)
    {
        this.Value = value;
    }
}
