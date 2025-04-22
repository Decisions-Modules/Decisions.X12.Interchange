namespace Decisions.X12.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class EdiSegmentAttribute : Attribute
{
    public string SegmentId { get; }

    public EdiSegmentAttribute(string segmentId)
    {
        SegmentId = segmentId;
    }
}