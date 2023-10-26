using System.Xml;
using System.Xml.Xsl;

namespace Decisions.X12.Transformations;

public abstract class X12TransformationService : ITransformationService
{
    private ITransformationService _preProcessor;

    public X12TransformationService(ITransformationService preProcessor)
    {
        _preProcessor = preProcessor;
    }

    protected abstract XslCompiledTransform GetTransform();

    protected virtual XsltArgumentList GetArguments()
    {
        return new XsltArgumentList();
    }


    #region ITransformationService Members

    public virtual string Transform(string x12)
    {
        string xml = _preProcessor.Transform(x12);

        XslCompiledTransform transform = GetTransform();

        var writer = new StringWriter();

        transform.Transform(XmlReader.Create(new StringReader(xml)), GetArguments(), writer);
        return writer.GetStringBuilder().ToString();
    }

    #endregion
}
