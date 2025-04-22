using X12Interchange837;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml837Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*SUBMITTERID    *ZZ*RECEIVERID     *250420*1200*^*00501*000000905*1*T*:~
                                    GS*HC*SUBMITTERID*RECEIVERID*20250420*1200*905*X*005010X222A1~
                                    ST*837*0001*005010X222A1~
                                    BHT*0019*00*0123*20250420*1200*CH~
                                    NM1*41*2*SUBMITTING PROVIDER*****46*1234567890~
                                    PER*IC*CONTACT NAME*TE*1234567890~
                                    NM1*40*2*RECEIVER*****46*9876543210~
                                    HL*1**20*1~
                                    NM1*85*2*BILLING PROVIDER*****XX*1234567893~
                                    N3*123 MAIN ST~
                                    N4*ANYTOWN*CA*90210~
                                    REF*EI*123456789~
                                    HL*2*1*22*0~
                                    SBR*P*18*******MC~
                                    NM1*IL*1*DOE*JOHN****MI*123456789~
                                    NM1*PR*2*MEDICARE*****PI*12345~
                                    CLM*26463774*100***11:B:1*Y*A*Y*I~
                                    HI*ABK:K219~
                                    SE*17*0001~
                                    GE*1*905~
                                    IEA*1*000000905~
                                    """;
    [Test]
    public void Deserialize837Test()
    {
        X12Interchange837.Interchange msg = X12Steps837.Deserialize837EDI(TEST_MSG);
        Assert.Multiple(() =>
        {
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT01, Is.EqualTo("0019"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT02, Is.EqualTo("00"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT03, Is.EqualTo("0123"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT04, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT05, Is.EqualTo("1200"));
            Assert.That(msg.FunctionGroup.Transaction.BHT.BHT06, Is.EqualTo("CH"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].HL.HL01, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].HL.HL02, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].HL.HL03, Is.EqualTo("20"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].HL.HL04, Is.EqualTo("1"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.N3.N301, Is.EqualTo("123 MAIN ST"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.N4.N401, Is.EqualTo("ANYTOWN"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.N4.N402, Is.EqualTo("CA"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.N4.N403, Is.EqualTo("90210"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.NM1.NM101, Is.EqualTo("85"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.NM1.NM102, Is.EqualTo("2"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.NM1.NM103, Is.EqualTo("BILLING PROVIDER"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.NM1.NM108, Is.EqualTo("XX"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.NM1.NM109, Is.EqualTo("1234567893"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.REF[0].REF01, Is.EqualTo("EI"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].ProviderNameLoop222.REF[0].REF02, Is.EqualTo("123456789"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].CLM.CLM01, Is.EqualTo("26463774"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].CLM.CLM02, Is.EqualTo("100"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].CLM.CLM05.CLM0501, Is.EqualTo("11"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].CLM.CLM05.CLM0502, Is.EqualTo("B"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].HI[0].HI01.HI0101, Is.EqualTo("ABK"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].ClaimInformationLoop222[0].HI[0].HI01.HI0102, Is.EqualTo("K219"));

            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].HL.HL01, Is.EqualTo("2"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].HL.HL02, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].HL.HL03, Is.EqualTo("22"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].HL.HL04, Is.EqualTo("0"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].PayerNameLoop222.NM1.NM101, Is.EqualTo("PR"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].PayerNameLoop222.NM1.NM102, Is.EqualTo("2"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].PayerNameLoop222.NM1.NM103, Is.EqualTo("MEDICARE"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].PayerNameLoop222.NM1.NM108, Is.EqualTo("PI"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].PayerNameLoop222.NM1.NM109, Is.EqualTo("12345"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SBR.SBR01, Is.EqualTo("P"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SBR.SBR02, Is.EqualTo("18"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SBR.SBR09, Is.EqualTo("MC"));
            
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM101, Is.EqualTo("IL"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM102, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM103, Is.EqualTo("DOE"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM104, Is.EqualTo("JOHN"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM105, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM106, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM107, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM108, Is.EqualTo("MI"));
            Assert.That(msg.FunctionGroup.Transaction.BillingProviderHierarchicalLevelLoop222[0].SubscriberHierarchicalLevelLoop222[0].SubscriberNameLoop222.NM1.NM109, Is.EqualTo("123456789"));
            
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM101, Is.EqualTo("40"));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM102, Is.EqualTo("2"));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM103, Is.EqualTo("RECEIVER"));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM104, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM105, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM106, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM107, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM108, Is.EqualTo("46"));
            Assert.That(msg.FunctionGroup.Transaction.ReceiverNameLoop222.NM1.NM109, Is.EqualTo("9876543210"));
            
            
            Assert.That(msg.FunctionGroup.Transaction.SE.SE01, Is.EqualTo("17"));
            Assert.That(msg.FunctionGroup.Transaction.SE.SE02, Is.EqualTo("0001"));
            
            Assert.That(msg.FunctionGroup.Transaction.ST.ST01, Is.EqualTo("837"));
            Assert.That(msg.FunctionGroup.Transaction.ST.ST02, Is.EqualTo("0001"));
            Assert.That(msg.FunctionGroup.Transaction.ST.ST03, Is.EqualTo("005010X222A1"));
            
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM101, Is.EqualTo("41"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM102, Is.EqualTo("2"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM103, Is.EqualTo("SUBMITTING PROVIDER"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM104, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM105, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM106, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM107, Is.EqualTo(""));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM108, Is.EqualTo("46"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.NM1.NM109, Is.EqualTo("1234567890"));
            
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.PER[0].PER01, Is.EqualTo("IC"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.PER[0].PER02, Is.EqualTo("CONTACT NAME"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.PER[0].PER03, Is.EqualTo("TE"));
            Assert.That(msg.FunctionGroup.Transaction.SubmitterNameLoop222.PER[0].PER04, Is.EqualTo("1234567890"));
            
            Assert.That(msg.FunctionGroup.GE.GE01, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.GE.GE02, Is.EqualTo("905"));
            
            Assert.That(msg.FunctionGroup.GS.GS01, Is.EqualTo("HC"));
            Assert.That(msg.FunctionGroup.GS.GS02, Is.EqualTo("SUBMITTERID"));
            Assert.That(msg.FunctionGroup.GS.GS03, Is.EqualTo("RECEIVERID"));
            Assert.That(msg.FunctionGroup.GS.GS04, Is.EqualTo("20250420"));
            Assert.That(msg.FunctionGroup.GS.GS05, Is.EqualTo("1200"));
            Assert.That(msg.FunctionGroup.GS.GS06, Is.EqualTo("905"));
            Assert.That(msg.FunctionGroup.GS.GS07, Is.EqualTo("X"));
            Assert.That(msg.FunctionGroup.GS.GS08, Is.EqualTo("005010X222A1"));
            
            Assert.That(msg.IEA.IEA01, Is.EqualTo("1"));
            Assert.That(msg.IEA.IEA02, Is.EqualTo("000000905"));
            
            Assert.That(msg.ISA.ISA01, Is.EqualTo("00"));
            Assert.That(msg.ISA.ISA02.Trim(), Is.EqualTo(""));
            Assert.That(msg.ISA.ISA03, Is.EqualTo("00"));
            Assert.That(msg.ISA.ISA04.Trim(), Is.EqualTo(""));
            Assert.That(msg.ISA.ISA05, Is.EqualTo("ZZ"));
            Assert.That(msg.ISA.ISA06.Trim(), Is.EqualTo("SUBMITTERID"));
            Assert.That(msg.ISA.ISA07, Is.EqualTo("ZZ"));
            Assert.That(msg.ISA.ISA08.Trim(), Is.EqualTo("RECEIVERID"));
            Assert.That(msg.ISA.ISA09, Is.EqualTo("250420"));
            Assert.That(msg.ISA.ISA10, Is.EqualTo("1200"));
            Assert.That(msg.ISA.ISA11, Is.EqualTo("^"));
            Assert.That(msg.ISA.ISA12, Is.EqualTo("00501"));
            Assert.That(msg.ISA.ISA13, Is.EqualTo("000000905"));
            Assert.That(msg.ISA.ISA14, Is.EqualTo("1"));
            Assert.That(msg.ISA.ISA15, Is.EqualTo("T"));
            Assert.That(msg.ISA.ISA16, Is.Null);
        });
    }
    
    
}