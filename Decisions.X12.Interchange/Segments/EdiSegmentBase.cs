using System.Reflection;
using Decisions.X12.Attributes;

namespace Decisions.X12.Interchange.Segments;

public abstract class EdiSegmentBase
{
    public virtual string ToEdi(char elementDelimiter = '*', char segmentTerminator = '~')
    {
        var type = GetType();
        var segmentId = type.GetCustomAttribute<EdiSegmentAttribute>()?.SegmentId
                        ?? throw new InvalidOperationException("Missing EdiSegment attribute.");

        var properties = type.GetProperties()
            .Select(p => new
            {
                Property = p,
                Attr = p.GetCustomAttribute<EdiElementAttribute>()
            })
            .Where(x => x.Attr != null)
            .OrderBy(x => x.Attr.Position);

        var values = properties
            .Select(x => x.Property.GetValue(this)?.ToString() ?? string.Empty)
            .ToList();

        values.Insert(0, segmentId); // Insert segment ID at the start

        return string.Join(elementDelimiter, values) + segmentTerminator;
    }

    public virtual void FromEdi(string ediLine, char elementDelimiter = '*')
    {
        var type = GetType();
        var expectedSegmentId = type.GetCustomAttribute<EdiSegmentAttribute>()?.SegmentId
                                ?? throw new InvalidOperationException("Missing EdiSegment attribute.");

        var parts = ediLine.TrimEnd('~').Split(elementDelimiter);
        if (parts.Length == 0 || parts[0] != expectedSegmentId)
            throw new InvalidOperationException(
                $"Segment ID mismatch. Expected '{expectedSegmentId}', got '{parts[0]}'.");

        var props = type.GetProperties()
            .Select(p => new
            {
                Property = p,
                Attr = p.GetCustomAttribute<EdiElementAttribute>()
            })
            .Where(x => x.Attr != null)
            .OrderBy(x => x.Attr.Position)
            .ToList();

        for (var i = 0; i < props.Count && i + 1 < parts.Length; i++) // +1 to skip segment ID
        {
            var value = Convert.ChangeType(parts[i + 1], props[i].Property.PropertyType);
            props[i].Property.SetValue(this, value);
        }
    }
}