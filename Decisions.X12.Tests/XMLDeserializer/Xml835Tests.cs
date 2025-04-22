using X12Interchange835;

namespace Decisions.X12.Tests.XMLDeserializer;

public class Xml835Tests
{
    private const string TEST_MSG = """
                                    ISA*00*          *00*          *ZZ*PAYORID        *ZZ*PROVIDERID     *250420*1400*^*00501*000000901*1*T*:~
                                    GS*HP*PAYORID*PROVIDERID*20250420*1400*901*X*005010X221A1~
                                    ST*835*0001~
                                    BPR*I*5000*C*CHK*01*999999999*DA*123456789*1234567890**01*999999999*DA*987654321*20250420~
                                    TRN*1*1234567890*9876543210~
                                    REF*EV*1234567~
                                    DTM*405*20250420~
                                    N1*PR*MEDICARE~
                                    N3*100 CMS BLVD~
                                    N4*BALTIMORE*MD*21244~
                                    PER*CX*CUSTOMER SERVICE*TE*8006334227~
                                    N1*PE*PROVIDER NAME~
                                    REF*PQ*PROVIDER TAX ID~
                                    LX*1~
                                    CLP*26463774*1*150*100*50*MC*1234567890*12*1~
                                    CAS*CO*45*50~
                                    NM1*QC*1*DOE*JANE****MI*123456789~
                                    DTM*232*20250415~
                                    DTM*233*20250420~
                                    SE*20*0001~
                                    GE*1*901~
                                    IEA*1*000000901~
                                    """;
    [Test]
    public void Deserialize835Test()
    {
        var msg = X12Steps835.Deserialize835EDI(TEST_MSG);
        Assert.Multiple(() =>
        {
            // BPR - Payment Details
            Assert.That(msg.FunctionGroup.Transaction.BPR.BPR01, Is.EqualTo("I"));
            Assert.That(msg.FunctionGroup.Transaction.BPR.BPR02, Is.EqualTo("5000"));
            Assert.That(msg.FunctionGroup.Transaction.BPR.BPR04, Is.EqualTo("CHK"));
            Assert.That(msg.FunctionGroup.Transaction.BPR.BPR15, Is.EqualTo("20250420"));

            // TRN - Trace
            Assert.That(msg.FunctionGroup.Transaction.TRN.TRN01, Is.EqualTo("1"));
            Assert.That(msg.FunctionGroup.Transaction.TRN.TRN02, Is.EqualTo("1234567890"));

            // REF - Receiver Reference ID
            Assert.That(msg.FunctionGroup.Transaction.REF[0].REF01, Is.EqualTo("EV"));
            Assert.That(msg.FunctionGroup.Transaction.REF[0].REF02, Is.EqualTo("1234567"));

            // DTM - Payment Date
            Assert.That(msg.FunctionGroup.Transaction.DTM.DTM01, Is.EqualTo("405"));
            Assert.That(msg.FunctionGroup.Transaction.DTM.DTM02, Is.EqualTo("20250420"));

            // Payer Info (N1 Loop)
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N1.N101, Is.EqualTo("PR"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N1.N102, Is.EqualTo("MEDICARE"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N3.N301, Is.EqualTo("100 CMS BLVD"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N4.N401, Is.EqualTo("BALTIMORE"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N4.N402, Is.EqualTo("MD"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.N4.N403, Is.EqualTo("21244"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.PER[0].PER02, Is.EqualTo("CUSTOMER SERVICE"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.PER[0].PER03, Is.EqualTo("TE"));
            Assert.That(msg.FunctionGroup.Transaction.PayerIdentificationLoop.PER[0].PER04, Is.EqualTo("8006334227"));

            // Payee Info (N1 Loop)
            Assert.That(msg.FunctionGroup.Transaction.PayeeIdentificationLoop.N1.N101, Is.EqualTo("PE"));
            Assert.That(msg.FunctionGroup.Transaction.PayeeIdentificationLoop.N1.N102, Is.EqualTo("PROVIDER NAME"));
            Assert.That(msg.FunctionGroup.Transaction.PayeeIdentificationLoop.REF[0].REF01, Is.EqualTo("PQ"));
            Assert.That(msg.FunctionGroup.Transaction.PayeeIdentificationLoop.REF[0].REF02, Is.EqualTo("PROVIDER TAX ID"));

            // Claim Payment Info (LX Loop)
            Assert.That(msg.FunctionGroup.Transaction.HeaderNumberLoop[0].LX.LX01, Is.EqualTo("1"));

            var clp = msg.FunctionGroup.Transaction.HeaderNumberLoop[0].ClaimPaymentInformationLoop[0].CLP;
            Assert.That(clp.CLP01, Is.EqualTo("26463774"));
            Assert.That(clp.CLP02, Is.EqualTo("1")); // Status: Processed as Primary
            Assert.That(clp.CLP03, Is.EqualTo("150")); // Billed amount
            Assert.That(clp.CLP04, Is.EqualTo("100")); // Paid amount
            Assert.That(clp.CLP05, Is.EqualTo("50"));  // Patient responsibility
            Assert.That(clp.CLP06, Is.EqualTo("MC"));  // Payer ID
            Assert.That(clp.CLP07, Is.EqualTo("1234567890")); // Payer claim control #
            Assert.That(clp.CLP09, Is.EqualTo("1")); // Claim filing indicator code

            // CAS - Adjustment
            var cas = msg.FunctionGroup.Transaction.HeaderNumberLoop[0].ClaimPaymentInformationLoop[0].CAS[0];
            Assert.That(cas.CAS01, Is.EqualTo("CO"));
            Assert.That(cas.CAS02, Is.EqualTo("45"));
            Assert.That(cas.CAS03, Is.EqualTo("50"));

            // NM1 - Patient
            var nm1 = msg.FunctionGroup.Transaction.HeaderNumberLoop[0].ClaimPaymentInformationLoop[0].NM1[0];
            Assert.That(nm1.NM101, Is.EqualTo("QC"));
            Assert.That(nm1.NM103, Is.EqualTo("DOE"));
            Assert.That(nm1.NM104, Is.EqualTo("JANE"));
            Assert.That(nm1.NM108, Is.EqualTo("MI"));
            Assert.That(nm1.NM109, Is.EqualTo("123456789"));

            // DTM - Service Date
            var dtm232 = msg.FunctionGroup.Transaction.HeaderNumberLoop[0].ClaimPaymentInformationLoop[0].DTM.FirstOrDefault(x => x.DTM01 == "232");
            Assert.That(dtm232.DTM02, Is.EqualTo("20250415"));

            var dtm233 = msg.FunctionGroup.Transaction.HeaderNumberLoop[0].ClaimPaymentInformationLoop[0].DTM.FirstOrDefault(x => x.DTM01 == "233");
            Assert.That(dtm233.DTM02, Is.EqualTo("20250420"));
        });
        
    }
}