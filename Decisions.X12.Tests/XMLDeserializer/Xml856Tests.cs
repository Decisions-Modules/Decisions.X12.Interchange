using X12Interchange856;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml856Tests
{
    private const string TEST_856 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *230706*1649*^*00501*000000914*1*T*:~
                                    GS*SH*SENDERID*RECEIVERID*20230706*1649*914*X*005010~
                                    ST*856*0001~
                                    BSN*00*XXX*20230706*1649*0001~
                                    HL*1**S*1~
                                    TD1*CTN*0****G*000000*KG~
                                    TD5**2*XXXXXXX*M*XXX*BO~
                                    TD3*2B**XXXX~
                                    REF*CN*XXXX~
                                    DTM*017*20230706~
                                    DTM*011*20230706~
                                    FOB*CC~
                                    N1*SF*XXX~
                                    N2*X~
                                    N3*XXX*XX~
                                    N4*XXXXXXX*XX*XXXXXXX*XXX~
                                    N1*ST*XXX~
                                    N2*XXXXXX~
                                    N3*X*XXX~
                                    N4*XXXXXXX*XX*XXXXXXXX*XX~
                                    HL*2*1*O*1~
                                    PRF*X***20230706~
                                    REF*DP*X~
                                    REF*19*XX~
                                    REF*IA*XXX~
                                    HL*3*2*P*1~
                                    PO4****CNT25**000000*LB~
                                    MAN*GM*XXXXX**CP*XX~
                                    HL*4*3*I*0~
                                    LIN*XXX*VN*XXXXX*UP*XXXX*HD*XXXX*HD*XX~
                                    SN1**0000*EA**00000000*CA~
                                    PO4*0~
                                    PID*F****XXXXX~
                                    CTT*00*0000000000*0000~
                                    SE*33*0001~
                                    GE*1*914~
                                    IEA*1*000000914~
                                    """;

    private const string TEST_855 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1605*^*00501*000000915*1*T*:~
                                    GS*PR*SENDERID*RECEIVERID*20250420*1605*915*X*005010~
                                    ST*855*0001~
                                    BAK*00*AT*1317126*20070611*0*850**0001369955~
                                    SE*3*0001~
                                    GE*1*915~
                                    IEA*1*000000915~
                                    """;

    [Test]
    public void Deserialize856ToXml_ValidDocument_Contains856TransactionSet()
    {
        var result = X12Steps856.Deserialize856EDI(TEST_856);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("856"));
        Assert.That(result.FunctionGroup.Transaction.BSN.BSN01, Is.EqualTo("00"));
        Assert.That(result.FunctionGroup.Transaction.HlLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.HlLoop[0].HL.HL03, Is.EqualTo("S"));
        Assert.That(result.FunctionGroup.Transaction.HlLoop[0].NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.HlLoop[0].NameAddressLoop.Length, Is.EqualTo(2));
    }

    [Test]
    public void Deserialize856ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps856.Deserialize856EDI(TEST_855));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 856"));
    }
}
