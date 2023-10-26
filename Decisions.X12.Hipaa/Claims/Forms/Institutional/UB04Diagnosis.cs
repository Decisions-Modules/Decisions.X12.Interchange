﻿namespace Decisions.X12.Hipaa.Claims.Forms.Institutional;

public class UB04Diagnosis
{
    public string Code { get; set; }
    public string PresentOnAdmissionIndicator { get; set; }

    public UB04Diagnosis CopyFrom(Diagnosis source)
    {
        Code = source.FormattedCode();
        PresentOnAdmissionIndicator = source.PoiIndicator;
        return this;
    }
}
