using Decisions.X12.Hipaa.Common;

namespace Decisions.X12.Hipaa.Claims.Forms.Institutional;

public class UB04Value
{
    public string Code { get; set; }
    public decimal? Amount { get; set; }

    public UB04Value CopyFrom(CodedAmount source)
    {
        Code = source.Code;
        Amount = source.Amount;
        return this;
    }
}
