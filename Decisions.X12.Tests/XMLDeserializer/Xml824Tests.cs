using X12Interchange824;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml824Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1600*^*00501*000000903*1*T*:~
                                    GS*AG*SENDERID*RECEIVERID*20250420*1600*903*X*005010X186A1~
                                    ST*824*0001~
                                    BGN*11*123456789*20250420*1600*PT~
                                    N1*41*SENDER COMPANY~
                                    N1*40*RECEIVER COMPANY~
                                    OTI*TR*123456789*20250420*0001*856*0001*DI~
                                    TED*812*INVALID ITEM NUMBER~
                                    NTE*ADD*The item number 12345 is not found in catalog.~
                                    SE*8*0001~
                                    GE*1*903~
                                    IEA*1*000000903~
                                    """;
    [Test]
    public void Deserialize824Test()
    {
        var msg = X12Steps824.Deserialize824(TEST_MSG);
        Assert.Multiple(() =>
        {
            // BGN - Beginning Segment
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN01, Is.EqualTo("11"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN02, Is.EqualTo("123456789"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN03, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN04, Is.EqualTo("1600"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN05, Is.EqualTo("PT"));

            // N1 - Sender
            Assert.That(msg.FunctionGroup.Transaction.N1Loop[0].N1.N101, Is.EqualTo("41"));
            Assert.That(msg.FunctionGroup.Transaction.N1Loop[0].N1.N102, Is.EqualTo("SENDER COMPANY"));

            // N1 - Receiver
            Assert.That(msg.FunctionGroup.Transaction.N1Loop[1].N1.N101, Is.EqualTo("40"));
            Assert.That(msg.FunctionGroup.Transaction.N1Loop[1].N1.N102, Is.EqualTo("RECEIVER COMPANY"));
        });
        
    }
}