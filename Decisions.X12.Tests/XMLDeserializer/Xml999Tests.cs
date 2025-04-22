using X12Interchange999;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml999Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1200*U*00401*000000001*0*P*:~
                                    GS*FA*SENDERID*RECEIVERID*20250420*1200*1*X*005010X231A1~
                                    ST*999*0001~
                                    AK1*HC*1234~
                                    AK2*837*0001~
                                    IK5*A~
                                    AK9*A*1*1*1~
                                    SE*6*0001~
                                    GE*1*1~
                                    IEA*1*000000001~
                                    """;
    
    [Test]
    public void Deserialize999Test()
    {
        X12Interchange999.Interchange msg = X12Steps999.Deserialize999(TEST_MSG);
        Assert.Multiple(() =>
        {
            Assert.That(msg.FunctionGroup.GE.GE01, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.GE.GE02, Is.EqualTo("1"));

            Assert.That(msg.FunctionGroup.GS.GS01, Is.EqualTo("FA"));
            Assert.That(msg.FunctionGroup.GS.GS02, Is.EqualTo("SENDERID"));
            Assert.That(msg.FunctionGroup.GS.GS03, Is.EqualTo("RECEIVERID"));
            Assert.That(msg.FunctionGroup.GS.GS04, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.GS.GS05, Is.EqualTo("1200"));
            Assert.That(msg.FunctionGroup.GS.GS06, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.GS.GS07, Is.EqualTo("X"));
            Assert.That(msg.FunctionGroup.GS.GS08, Is.EqualTo("005010X231A1"));

            Assert.That(msg.FunctionGroup.Transaction.AK1.AK101, Is.EqualTo("HC"));
            Assert.That(msg.FunctionGroup.Transaction.AK1.AK102, Is.EqualTo("1234"));
            Assert.That(msg.FunctionGroup.Transaction.AK1.AK103, Is.Null);

            Assert.That(msg.FunctionGroup.Transaction.AK9.AK901, Is.EqualTo("A"));
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK902, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK903, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK904, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK905, Is.Null);
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK906, Is.Null);
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK907, Is.Null);
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK908, Is.Null);
            Assert.That(msg.FunctionGroup.Transaction.AK9.AK909, Is.Null);

            Assert.That(msg.FunctionGroup.Transaction.SE.SE01, Is.EqualTo("6"));
            Assert.That(msg.FunctionGroup.Transaction.SE.SE02, Is.EqualTo("0001"));

            Assert.That(msg.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("999"));
            Assert.That(msg.FunctionGroup.Transaction.ST.ST02, Is.EqualTo("0001"));
            Assert.That(msg.FunctionGroup.Transaction.ST.ST03, Is.Null);

            Assert.That(msg.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000[0].AK2.AK201, Is.EqualTo("837"));
            Assert.That(msg.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000[0].AK2.AK202, Is.EqualTo("0001"));
            Assert.That(msg.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000[0].AK2.AK203, Is.Null);

            Assert.That(msg.FunctionGroup.Transaction.TransactionSetResponseHeaderLoop2000[0].IK5.IK501, Is.EqualTo("A"));
        });


    }
}