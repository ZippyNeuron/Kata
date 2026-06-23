using ZippyNeuron.Kata.WeIrDStRiNgCaSe;

namespace ZippyNeuron.Kata.Test.WeIrDStRiNgCaSe;

[TestFixture]
internal class WeIrDStRiNgCaSeTests
{
    private static void DoTest(String input, String expected)
    {
        String actual = WeIrDStRiNgCaSeKata.ToWeirdCase(input);
        Assert.That(actual, Is.EqualTo(expected), "for input: \"" + input + "\"\n");
    }

    [Test]
    public static void ShouldWorkForSomeExamples()
    {
        DoTest("This", "ThIs");
        DoTest("is", "Is");
        DoTest("This is a test", "ThIs Is A TeSt");
    }
}