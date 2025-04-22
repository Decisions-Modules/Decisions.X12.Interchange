using X12Interchange834;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml834Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *250420*1500*^*00501*000000902*1*T*:~
                                    GS*BE*SENDERID*RECEIVERID*20250420*1500*902*X*005010X220A1~
                                    ST*834*0001*005010X220A1~
                                    BGN*00*123456789*20250420*1500*PT***
                                    REF*38*123456789~
                                    DTP*007*D8*20250401~
                                    N1*P5*ACME CORPORATION~
                                    N1*IN*INSURANCE CO~
                                    INS*Y*18*030*XN*A*E**FT~
                                    REF*0F*123456789~
                                    DTP*356*D8*19800101~
                                    NM1*IL*1*DOE*JANE****34*123456789~
                                    PER*IP**HP*8005551234~
                                    N3*456 OAK STREET~
                                    N4*ANYTOWN*CA*90210~
                                    DMG*D8*19800101*F~
                                    HD*030**HLT~
                                    DTP*348*D8*20250401~
                                    SE*18*0001~
                                    GE*1*902~
                                    IEA*1*000000902~
                                    """;
    [Test]
    public void Deserialize834Test()
    {
        X12Interchange834.Interchange msg = X12Steps834.DeserializeFrom834(TEST_MSG);
        Assert.Multiple(() =>
        {
            // BGN - Beginning Segment
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN01, Is.EqualTo("00"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN02, Is.EqualTo("123456789"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN03, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN04, Is.EqualTo("1500"));
            Assert.That(msg.FunctionGroup.Transaction.BGN.BGN05, Is.EqualTo("PT"));
            
            // DTP - File Effective Date
            Assert.That(msg.FunctionGroup.Transaction.DTP.DTP01, Is.EqualTo("007"));
            Assert.That(msg.FunctionGroup.Transaction.DTP.DTP02, Is.EqualTo("D8"));
            Assert.That(msg.FunctionGroup.Transaction.DTP.DTP03, Is.EqualTo("20250401"));

            // N1 - Sponsor / Employer Name
            Assert.That(msg.FunctionGroup.Transaction.SponsorNameLoop.N1.N101, Is.EqualTo("P5"));
            Assert.That(msg.FunctionGroup.Transaction.SponsorNameLoop.N1.N102, Is.EqualTo("ACME CORPORATION"));

            // INS - Member Level Detail
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS01, Is.EqualTo("Y"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS02, Is.EqualTo("18"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS03, Is.EqualTo("030"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS04, Is.EqualTo("XN"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS05, Is.EqualTo("A"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].INS.INS08, Is.EqualTo("FT"));

            // REF - Subscriber ID
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].REF.REF01, Is.EqualTo("0F"));
            Assert.That(msg.FunctionGroup.Transaction.MemberLevelDetailLoop[0].REF.REF02, Is.EqualTo("123456789"));
        });
        
    }
}