﻿using Decisions.X12.Attributes;

namespace Decisions.X12.Parsing.Model.Typed;

public enum PricingMethodology
{
    [EDIFieldValue("00")]
    ZeroPricing_NotCoveredUnderContract,
    [EDIFieldValue("01")]
    PricedAsBilledAt100Percent,
    [EDIFieldValue("02")]
    PricedAtTheStandardFeeSchedule,
    [EDIFieldValue("03")]
    PricedAtAContractualPercentage,
    [EDIFieldValue("04")]
    BundledPricing,
    [EDIFieldValue("05")]
    PeerReviewPricing,
    [EDIFieldValue("06")]
    PerDiemPricing,
    [EDIFieldValue("07")]
    FlatRatePricing,
    [EDIFieldValue("08")]
    CombinationPricing,
    [EDIFieldValue("09")]
    MaternityPricing,
    [EDIFieldValue("10")]
    OtherPricing,
    [EDIFieldValue("11")]
    LowerOfCost,
    [EDIFieldValue("12")]
    RatioOfCost,
    [EDIFieldValue("13")]
    CostReimbursed,
    [EDIFieldValue("14")]
    AdjustmentPricing
}
