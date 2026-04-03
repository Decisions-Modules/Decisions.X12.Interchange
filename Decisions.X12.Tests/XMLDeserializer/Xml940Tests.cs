using X12Interchange940;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml940Tests
{
    private const string TEST_940 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *230707*1200*^*00401*000000910*0*T*>~
                                    GS*OW*SENDERID*RECEIVERID*20230707*1200*910*X*004010~
                                    ST*940*0001~
                                    W05*N*XXXXX*XXXXXX~
                                    N1*ST*XXXXXX*92*XXXXX~
                                    N3*XXX*XXXXX~
                                    N4*XXXXXXX*XX*XXXXXXXX*XXX~
                                    N9*DP*XX~
                                    N9*MR*XXXXXX~
                                    G62*38*20230707~
                                    G62*02*20230707~
                                    G62*37*20230707~
                                    NTE*WHI*XXXX~
                                    W66*TP*U***XX*XX*XXXXX***XX~
                                    LX*000~
                                    W01*00000000*XX*XXXXXXXXXXXX*UP*XXXXXX*IN*XXXXX********VN*XXX~
                                    G69*X~
                                    W76*000*0000000000*XX*0000000*XX*0~
                                    SE*17*0001~
                                    GE*1*910~
                                    IEA*1*000000910~
                                    """;

    private const string TEST_945 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1545*^*00501*000000911*1*T*:~
                                    GS*SW*SENDERID*RECEIVERID*20250420*1545*911*X*005010~
                                    ST*945*0001~
                                    W06*X*XX*20230707*XXX**XXX~
                                    SE*3*0001~
                                    GE*1*911~
                                    IEA*1*000000911~
                                    """;

    [Test]
    public void Deserialize940ToXml_ValidDocument_Contains940TransactionSet()
    {
        var result = X12Steps940.Deserialize940EDI(TEST_940);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("940"));
        Assert.That(result.FunctionGroup.Transaction.W05.W0501, Is.EqualTo("N"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("ST"));
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.AssignedNumberLoop[0].LX.LX01, Is.EqualTo("000"));
    }

    [Test]
    public void Deserialize940ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps940.Deserialize940EDI(TEST_945));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 940"));
    }
}
