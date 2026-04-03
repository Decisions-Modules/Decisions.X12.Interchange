using X12Interchange855;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml855Tests
{
    private const string TEST_855 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1500*^*00501*000000902*1*T*:~
                                    GS*PR*SENDERID*RECEIVERID*20250420*1500*902*X*005010~
                                    ST*855*0001~
                                    BAK*00*AT*1317126*20070611*0*850**0001369955~
                                    REF*YB*Revision Number~
                                    REF*ZZ*Handset Device Accessory~
                                    PER*BD*FirstName LastName*TE*123-456-7890~
                                    DTM*008*20070620~
                                    N1*ST*Ship To Name*92*Ship To Code~
                                    N3*STREET ADDRESS~
                                    N4*CITY*ST*ZIPCO*US~
                                    N1*SU*Supplier Name*92*Supplier Code~
                                    N3*STREET ADDRESS~
                                    N4*CITY*ST*ZIPCO*US~
                                    PO1*1*100*EA*424**SK*RTL.12345*VN*Vendor Item Number~
                                    PID*F****ITEM DESCRIPTION~
                                    ACK*IA*120*EA*017*20070608**SK*RTL.29805~
                                    N9*ZZ*DETAIL MESSAGE NOTES~
                                    CTT*1~
                                    SE*19*0001~
                                    GE*1*902~
                                    IEA*1*000000902~
                                    """;

    private const string TEST_850 = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1500*^*00501*000000903*1*T*:~
                                    GS*PO*SENDERID*RECEIVERID*20250420*1500*903*X*005010~
                                    ST*850*0001~
                                    BEG*00*SA*XX**20230704~
                                    SE*3*0001~
                                    GE*1*903~
                                    IEA*1*000000903~
                                    """;

    [Test]
    public void Deserialize855ToXml_ValidDocument_Contains855TransactionSet()
    {
        var result = X12Steps855.Deserialize855EDI(TEST_855);

        Assert.That(result.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("855"));
        Assert.That(result.FunctionGroup.Transaction.BAK.BAK01, Is.EqualTo("00"));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop.Length, Is.EqualTo(2));
        Assert.That(result.FunctionGroup.Transaction.NameAddressLoop[0].N1.N101, Is.EqualTo("ST"));
        Assert.That(result.FunctionGroup.Transaction.LineItemLoop, Is.Not.Null);
        Assert.That(result.FunctionGroup.Transaction.LineItemLoop.Length, Is.EqualTo(1));
        Assert.That(result.FunctionGroup.Transaction.LineItemLoop[0].PO1.PO101, Is.EqualTo("1"));
    }

    [Test]
    public void Deserialize855ToXml_WrongTransactionSet_ThrowsInvalidOperationException()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            X12Steps855.Deserialize855EDI(TEST_850));

        Assert.That(ex.Message, Is.EqualTo("Incorrect document being used. Please use 855"));
    }
}
