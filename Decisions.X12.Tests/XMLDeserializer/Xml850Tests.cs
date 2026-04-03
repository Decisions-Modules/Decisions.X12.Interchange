using X12Interchange850;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml850Tests
{
    private const string TEST_850 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *230704*1200*^*00501*000000908*1*T*:~
                                    GS*PO*SENDERID*RECEIVERID*20230704*1200*908*X*005010~
                                    ST*850*0001~
                                    BEG*00*SA*XX**20230704~
                                    CUR*BY*XXX**SE*XXX~
                                    REF*DP*X~
                                    REF*19*XXXXX~
                                    REF*IA*X~
                                    PER*BD*XX*TE*XX*FX*XXXX*EM*XX~
                                    FOB*PP*DE*X***DE*X~
                                    ITD*ZZ*3*00**000**0*****XXXXX~
                                    DTM*155*20230705~
                                    DTM*001*20230705~
                                    DTM*010*20230705~
                                    TD5**2*XXXXXX*A*X~
                                    N9*L1*XX~
                                    N1*ST*XXXXX*92*XXX~
                                    N2*XXXX~
                                    N3*XXXXXX*XXXXXX~
                                    N4*XXXX*XX*XXXX*XXX~
                                    PER*IC*XXX*TE*X*FX*XXXX*EM*XXXX~
                                    N1*VN*XX*92*XXXXXX~
                                    N2*XXXXXX~
                                    N3*XXXX*XX~
                                    N4*XX*XX*XXXXXXXX*XX~
                                    PER*IC*XX*TE*XXXXX*FX*XXXXX*EM*X~
                                    PO1*XX*000000000000*EA*00000000*UM*VN*XXXXX*UP*XX*SK*XXX~
                                    CTP**DPR*000000000000000~
                                    PID*F****XXXX~
                                    PO4*00~
                                    DTM*063*20230705~
                                    TC2*A*XXX~
                                    CTT*00000*0000~
                                    AMT*TT*00000~
                                    SE*33*0001~
                                    GE*1*908~
                                    IEA*1*000000908~
                                    """;

    private const string TEST_810 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1535*^*00501*000000909*1*T*:~
                                    GS*IN*SENDERID*RECEIVERID*20250420*1535*909*X*005010~
                                    ST*810*0001~
                                    BIG*20230705*XXXX*20230706*XX***DR~
                                    SE*3*0001~
                                    GE*1*909~
                                    IEA*1*000000909~
                                    """;

    private const string TEST_850_STEDI_VARIANT = """
                                                  ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *260327*1200*U*00401*000000850*0*T*>~
                                                  GS*PO*SENDERID*RECEIVERID*20260327*1200*850*X*004010~
                                                  ST*850*0001~
                                                  BEG*00*SA*XX**20230704~
                                                  CUR*BY*XXX**SE*XXX~
                                                  REF*DP*X~
                                                  REF*19*XXXXX~
                                                  REF*IA*X~
                                                  PER*BD*XX*TE*XX*FX*XXXX*EM*XX~
                                                  FOB*PP*DE*X***DE*X~
                                                  ITD*ZZ*3*00**000**0*****XXXXX~
                                                  DTM*155*20230705~
                                                  DTM*001*20230705~
                                                  DTM*010*20230705~
                                                  TD5**2*XXXXXX*A*X~
                                                  N9*L1*XX~
                                                  MTX**XXXXXX~
                                                  N1*ST*XXXXX*92*XXX~
                                                  N2*XXXX~
                                                  N3*XXXXXX*XXXXXX~
                                                  N4*XXXX*XX*XXXX*XXX~
                                                  PER*IC*XXX*TE*X*FX*XXXX*EM*XXXX~
                                                  N1*VN*XX*92*XXXXXX~
                                                  N2*XXXXXX~
                                                  N3*XXXX*XX~
                                                  N4*XX*XX*XXXXXXXX*XX~
                                                  PER*IC*XX*TE*XXXXX*FX*XXXXX*EM*X~
                                                  PO1*XX*000000000000*EA*00000000*UM*VN*XXXXX*UP*XX*SK*XXX~
                                                  CTP**DPR*000000000000000~
                                                  PID*F****XXXX~
                                                  PO4*00~
                                                  DTM*063*20230705~
                                                  TC2*A*XXX~
                                                  CTT*00000*0000~
                                                  AMT*TT*00000~
                                                  SE*34*0001~
                                                  GE*1*850~
                                                  IEA*1*000000850~
                                                  """;

    [Test]
    public void Deserialize850ToXml_ValidDocument_Contains850TransactionSet()
    {
        var result = X12Steps850.Deserialize850EDI(TEST_850);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("850"));
        Assert.That(result.FunctionGroup.Transaction.BEG.BEG01, Is.EqualTo("00"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(2));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("ST"));
        Assert.That(result.FunctionGroup.Transaction.POLineItemLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.POLineItemLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.POLineItemLoop[0].PO1.PO101, Is.EqualTo("XX"));
    }

    [Test]
    public void Deserialize850ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps850.Deserialize850EDI(TEST_810));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 850"));
    }

    [Test]
    public void Deserialize850ToXml_StediVariantWithMtx_ParsesSuccessfully()
    {
        var result = X12Steps850.Deserialize850EDI(TEST_850_STEDI_VARIANT);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("850"));
        Assert.That(result.FunctionGroup.Transaction.BEG.BEG01, Is.EqualTo("00"));
    }
}
