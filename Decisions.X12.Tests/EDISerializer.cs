using Decisions.X12.Interchange.Segments;

namespace Decisions.X12.Tests;

public class EDISerializer
{
    [Test]
    public void SerializeTA1()
    {
        TA1 ta = new TA1()
        {
            TA101 = "aaa",
            TA102 = "bbb",
            TA103 = "ccc",
            TA104 = "ddd",
            TA105 = "eee"
        };

        string output = ta.ToEdi();
        Assert.That(output, Is.EqualTo("TA1*aaa*bbb*ccc*ddd*eee~"));

    }

    [Test]
    public void DeserializeTA1()
    {
        TA1 ta = new TA1();
        ta.FromEdi("TA1*aaa*bbb*ccc*ddd*eee~");
        
        Assert.That(ta.TA101, Is.EqualTo("aaa"));
        Assert.That(ta.TA102, Is.EqualTo("bbb"));
        Assert.That(ta.TA103, Is.EqualTo("ccc"));
        Assert.That(ta.TA104, Is.EqualTo("ddd"));
        Assert.That(ta.TA105, Is.EqualTo("eee"));
    }
}