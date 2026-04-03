using X12Interchange945;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml945Tests
{
    private const string TEST_945 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *230707*1200*^*00401*000000904*0*T*>~
                                    GS*SW*SENDERID*RECEIVERID*20230707*1200*904*X*004010~
                                    ST*945*0001~
                                    W06*X*XX*20230707*XXX**XXX~
                                    N1*ST*XXX~
                                    N9*BM*XXX~
                                    N9*IV*X~
                                    G62*03*20230707~
                                    W27*X*XXX*XXXXXX*XX*XX*XXXX*X~
                                    LX*000000~
                                    MAN*GM*X~
                                    W12*XX*00*000*000*XX*XXXXXXXXXXXX*MN*XXXXX**00000*XX*X~
                                    W03*00000000*000000*XX*00000*XX*0000*XX~
                                    SE*12*0001~
                                    GE*1*904~
                                    IEA*1*000000904~
                                    """;

    private const string TEST_940 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1515*^*00501*000000905*1*T*:~
                                    GS*OW*SENDERID*RECEIVERID*20250420*1515*905*X*005010~
                                    ST*940*0001~
                                    W05*N*XXXXX*XXXXXX~
                                    SE*3*0001~
                                    GE*1*905~
                                    IEA*1*000000905~
                                    """;

    [Test]
    public void Deserialize945ToXml_ValidDocument_Contains945TransactionSet()
    {
        var result = X12Steps945.Deserialize945EDI(TEST_945);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("945"));
        Assert.That(result.FunctionGroup.Transaction.W06.W0601, Is.EqualTo("X"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("ST"));
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop[0].LX.LX01, Is.EqualTo("000000"));
    }

    [Test]
    public void Deserialize945ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps945.Deserialize945EDI(TEST_940));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 945"));
    }
}
