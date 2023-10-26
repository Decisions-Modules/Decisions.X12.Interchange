using Decisions.X12.Parsing;
using Decisions.X12.Parsing.Model;
using System.Text;

namespace Decisions.X12.Transformations;

public class X12EdiParsingService : ITransformationService
{
    private bool _suppressComments;
    private X12Parser _parser;

    public X12EdiParsingService(bool suppressComments, X12Parser parser)
    {
        _suppressComments = suppressComments;
        _parser = parser;
    }

    public X12EdiParsingService(bool suppressComments) : this(suppressComments, new X12Parser()) { }

    public X12EdiParsingService(bool suppressComments, ISpecificationFinder specFinder) : this(suppressComments, new X12Parser(specFinder, true)) { }

    public string Transform(string x12)
    {
        Interchange interchange = _parser.ParseMultiple(new MemoryStream(Encoding.ASCII.GetBytes(x12))).FirstOrDefault();
        return interchange.Serialize(_suppressComments);
    }

}
