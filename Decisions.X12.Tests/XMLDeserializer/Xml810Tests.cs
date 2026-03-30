using X12Interchange810;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml810Tests
{
    private const string TEST_810 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *230705*1200*^*00501*000000906*1*T*:~
                                    GS*IN*SENDERID*RECEIVERID*20230705*1200*906*X*005010~
                                    ST*810*0001~
                                    BIG*20230705*XXXX*20230706*XX***DR~
                                    NTE**XXXXX~
                                    CUR*BY*XXX**SE*XXX~
                                    REF*DP*X~
                                    N1*RI*XX*1*XX~
                                    N3*XXXXX*X~
                                    N4*XXX*XX*XXXXX*XXX~
                                    PER*IC*XX*FX*XXXXX*TE*XXXX*FX*XXX~
                                    N1*ST*X*92*XXXXX~
                                    N3*XX*XXX~
                                    N4*XXX*XX*XXXXX*XX~
                                    PER*IC*XXXX*EM*XXX*TE*X*TE*XXX~
                                    N1*VN*X*1*XX~
                                    N3*X*XXXXXX~
                                    N4*XXXXXX*XX*XXX*XXX~
                                    PER*IC*XXX*FX*XXX*EM*XX*EM*XXXXXX~
                                    ITD*08*3*0000**000**00*****XXX~
                                    DTM*011*20230705~
                                    FOB*PP*DE*XXXXX***OR*XXXXX~
                                    IT1*X*00*EA*00*UM*VN*XXX*EN*XXXX*EN*XXXXXX*UP*XX~
                                    IT3***BO*0~
                                    CTP**DPR*00000~
                                    PID*F****XXX~
                                    TDS*0*00000*0000000000*0~
                                    CAD*A***XXX*XXXXXX*PR*2I*XX*XX~
                                    SAC*C*C000***000000**********XXX~
                                    CTT*000000*00~
                                    SE*29*0001~
                                    GE*1*906~
                                    IEA*1*000000906~
                                    """;

    private const string TEST_850 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1525*^*00501*000000907*1*T*:~
                                    GS*PO*SENDERID*RECEIVERID*20250420*1525*907*X*005010~
                                    ST*850*0001~
                                    BEG*00*SA*XX**20230704~
                                    SE*3*0001~
                                    GE*1*907~
                                    IEA*1*000000907~
                                    """;

    [Test]
    public void Deserialize810ToXml_ValidDocument_Contains810TransactionSet()
    {
        var result = X12Steps810.Deserialize810EDI(TEST_810);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("810"));
        Assert.That(result.FunctionGroup.Transaction.BIG.BIG01, Is.EqualTo("20230705"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(3));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("RI"));
        Assert.That(result.FunctionGroup.Transaction.InvoiceLineItemLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.InvoiceLineItemLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.InvoiceLineItemLoop[0].IT1.IT101, Is.EqualTo("X"));
    }

    [Test]
    public void Deserialize810ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps810.Deserialize810EDI(TEST_850));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 810"));
    }
}
