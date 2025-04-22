namespace Decisions.X12.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class EdiElementAttribute : Attribute
{
    public int Position { get; }

    public EdiElementAttribute(int position)
    {
        Position = position;
    }
}