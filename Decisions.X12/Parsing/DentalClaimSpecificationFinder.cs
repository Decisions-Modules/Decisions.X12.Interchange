﻿namespace Decisions.X12.Parsing;

public class DentalClaimSpecificationFinder : SpecificationFinder
{
    public override Specification.TransactionSpecification FindTransactionSpec(string functionalCode, string versionCode, string transactionSetCode)
    {
        if (transactionSetCode == "837")
        {
            //if (versionCode.Contains("5010"))
            //    return SpecificationFinder.GetSpecification("837D-5010");
            //else
            return SpecificationFinder.GetSpecification("837D-4010");
        }
        else
            return base.FindTransactionSpec(functionalCode, versionCode, transactionSetCode);
    }
}
