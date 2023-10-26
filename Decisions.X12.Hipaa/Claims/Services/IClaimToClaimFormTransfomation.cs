using Decisions.X12.Hipaa.Claims.Forms;

namespace Decisions.X12.Hipaa.Claims.Services
{
    public interface IClaimToClaimFormTransfomation
    {
        List<FormPage> TransformClaimToClaimFormFoXml(Claim claim);
    }
}
