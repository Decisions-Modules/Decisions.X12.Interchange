using Decisions.X12.Parsing;

namespace Decisions.X12.Validation;

public class InstitutionalClaimAcknowledgmentService : X12AcknowledgmentService
{
    public InstitutionalClaimAcknowledgmentService()
        : base(new InstitutionalClaimSpecificationFinder())
    {
    }


}
