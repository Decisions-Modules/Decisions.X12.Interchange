using X12Interchange944;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml944Tests
{
    private const string TEST_944 = """
                                    ISA*00*          *00*          *ZZ*SENDER         *ZZ*RECEIVER       *231207*0411*U*00401*000000912*0*T*>~
                                    GS*RE*SENDERGS*RECEIVERGS*20231207*041106*912*X*004010~
                                    ST*944*000001234~
                                    W17*J*20050601*WH12345*105710010*100124~
                                    N1*SF*LANDO LLC~
                                    N3*151 NAMBOO STC~
                                    N4*DAVENPORT*IW*69402~
                                    PER*CN*WEDGE ANTILLES*TE*(582) 482-4388~
                                    N1*RC*3PL WHSE DALLAS NORTH*ZZ*N001~
                                    N3*85 HIGHWAY 110~
                                    N4*DALLAS*TX*45920~
                                    PER*CN*BOB THORNTON*TE*(491) 948-4820*EM*bob.thornton@3pl.com~
                                    N9*ZZ*TRANSFER TO TAKE PLACE 6/12/05~
                                    G62*AB*20060612~
                                    NTE*ALT*SOME ITEMS DAMAGED IN TRANSFER (1 CARTON CRUSHED)~
                                    NTE*ALT*INVENTORY TO BE SHIPPED IN LOOSE CARTONS (NOT ON PALLETS)~
                                    W08*M*DTEY*DILLON TEYBOR TRANSPORT~
                                    W07*250*EA**UP*582058001851*VA*5820-01P***LT*4880~
                                    G69*XWING FLIGHT SUITS~
                                    N9*LI*1~
                                    W07*500*EA**UP*582058001302*VA*5820-O2P***LT*4880~
                                    G69*XWING FLIGHT SUITS~
                                    N9*LI*2~
                                    W13*10*EA*01**HD~
                                    W07*250*EA**UP*582058001469*VA*5820-03P***LT*4881~
                                    G69*XWING FLIGHT SUITS~
                                    N9*LI*1~
                                    W14*1250~
                                    SE*27*000001234~
                                    GE*1*912~
                                    IEA*1*000000912~
                                    """;

    private const string TEST_940 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1555*^*00501*000000913*1*T*:~
                                    GS*OW*SENDERID*RECEIVERID*20250420*1555*913*X*005010~
                                    ST*940*0001~
                                    W05*N*XXXXX*XXXXXX~
                                    SE*3*0001~
                                    GE*1*913~
                                    IEA*1*000000913~
                                    """;

    [Test]
    public void Deserialize944ToXml_ValidDocument_Contains944TransactionSet()
    {
        var result = X12Steps944.Deserialize944EDI(TEST_944);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("944"));
        Assert.That(result.FunctionGroup.Transaction.W17.W1701, Is.EqualTo("J"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(2));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("SF"));
        Assert.That(result.FunctionGroup.Transaction.ItemDetailReceiptLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.ItemDetailReceiptLoop.Length, Is.EqualTo(3));
        Assert.That(result.FunctionGroup.Transaction.ItemDetailReceiptLoop[0].W07.W0701, Is.EqualTo("250"));
    }

    [Test]
    public void Deserialize944ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps944.Deserialize944EDI(TEST_940));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 944"));
    }
}
