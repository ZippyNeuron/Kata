using ZippyNeuron.Kata.WhichAreIn;

namespace ZippyNeuron.Kata.Test.WhichAreIn;

[TestFixture]
public class WhichAreInTests
{
    [Test]
    public void Test1()
    {
        string[] a1 = { "arp", "live", "strong" };
        string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
        string[] r = { "arp", "live", "strong" };
        Assert.That(WhichAreInKata.inArray(a1, a2), Is.EqualTo(r));
    }

    [Test]
    public void Test2()
    {
        string[] a1 = { };
        string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
        string[] r =  { };
        Assert.That(WhichAreInKata.inArray(a1, a2), Is.EqualTo(r));
    }

    [Test]
    public void Test3()
    {
        string[] a1 = { "wibble" };
        string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
        string[] r = { };
        Assert.That(WhichAreInKata.inArray(a1, a2), Is.EqualTo(r));
    }
}
