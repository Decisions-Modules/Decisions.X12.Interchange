using X12Interchange278;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml278Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*TESTGS1234    *ZZ*RECEIVER       *20250420*1234*U*00401*000000001*0*P*|
                                    GS*HS*TESTGS1234*RECEIVER*20250420*1234*1*X*004010X096A1|
                                    ST*278*00000001*0001|
                                    BHT*0019*00*0123*20250420*1200*CH|
                                    HL*1**20*1|
                                    NM1*PR*2*INSURANCE COMPANY***PI*12345|
                                    HL*2*1*21*1|
                                    NM1*41*2*PROVIDER NAME*****XX*9876543210|
                                    HL*3*2*22*1|
                                    NM1*IL*1*DOE*JANE****MI*123456789|
                                    DTP*291*D8*20250501|
                                    SE*10*00000001|
                                    GE*1*1|
                                    IEA*1*000000001|
                                    """;
    [Test]
    public void Deserialize278Test()
    {
        var msg = X12Steps278.Deserialize278X217Review(TEST_MSG);
        Assert.Multiple(() =>
        {
            // BHT - Beginning Hierarchical Transaction
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT01, Is.EqualTo("0019"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT02, Is.EqualTo("00"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT03, Is.EqualTo("0123"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT04, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT05, Is.EqualTo("1200"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT06, Is.EqualTo("CH"));
        });
        
    }
}