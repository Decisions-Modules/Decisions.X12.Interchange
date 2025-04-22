using X12Interchange277;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml277Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*RECEIVERID     *ZZ*SENDERID       *250420*1800*^*00501*000000905*1*T*:~
                                    GS*HN*RECEIVERID*SENDERID*20250420*1800*905*X*005010X212~
                                    ST*277*0001*005010X212~
                                    BHT*0010*08*277RESP001*20250420*1800*RP~
                                    HL*1**20*1~
                                    NM1*PR*2*INSURANCE CO*****PI*12345~
                                    HL*2*1*21*1~
                                    NM1*41*2*SUBMITTING PROVIDER*****46*9876543210~
                                    HL*3*2*19*0~
                                    NM1*1P*2*RENDERING PROVIDER*****XX*1234567893~
                                    HL*4*3*22*0~
                                    NM1*IL*1*DOE*JANE****MI*123456789~
                                    TRN*2*0001*9876543210~
                                    STC*A1:19:PR*20250418*WQ~
                                    REF*1K*ABC1234567~
                                    DTP*472*D8*20250415~
                                    SE*17*0001~
                                    GE*1*905~
                                    IEA*1*000000905~
                                    """;

    [Test]
    public void Deserialize277Test()
    {
        var msg = X12Steps277.Deserialize277X364(TEST_MSG);
        Assert.Multiple(() =>
        {
            // BHT - Beginning of Hierarchical Transaction
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT01, Is.EqualTo("0010"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT02, Is.EqualTo("08"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT03, Is.EqualTo("277RESP001"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT04, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT05, Is.EqualTo("1800"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT06, Is.EqualTo("RP"));

            // HL - Payer
            var payer = msg.FunctionGroup.Transaction.SourceLevelLoop3642000A[0];
            Assert.That(payer.HL.HL01, Is.EqualTo("1"));
            Assert.That(payer.HL.HL03, Is.EqualTo("20"));
            Assert.That(payer.PayerNameLoop3642100A.NM1.NM101, Is.EqualTo("PR"));
            Assert.That(payer.PayerNameLoop3642100A.NM1.NM103, Is.EqualTo("INSURANCE CO"));
            Assert.That(payer.PayerNameLoop3642100A.NM1.NM108, Is.EqualTo("PI"));
            Assert.That(payer.PayerNameLoop3642100A.NM1.NM109, Is.EqualTo("12345"));
        });
        
    }
    
}