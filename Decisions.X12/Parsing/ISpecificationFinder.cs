using Decisions.X12.Parsing.Specification;

namespace Decisions.X12.Parsing;

public interface ISpecificationFinder
{
    TransactionSpecification FindTransactionSpec(string functionalCode, string versionCode, string transactionSetCode);
    SegmentSpecification FindSegmentSpec(string versionCode, string segmentId);
}
