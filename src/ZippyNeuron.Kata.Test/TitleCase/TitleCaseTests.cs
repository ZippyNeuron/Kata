using ZippyNeuron.Kata.TitleCase;

namespace ZippyNeuron.Kata.Test.TitleCase;

[TestFixture]
public class TitleCaseTests
{
    [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
    [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
    [Order(1)]
    public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
    {
        Assert.That(TitleCaseKata.TitleCase(sampleTitle, sampleMinorWords), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void MyTest2()
    {
        Assert.That(TitleCaseKata.TitleCase(""), Is.EqualTo(""));
    }

    [Test, Order(3)]
    public void MyTest3()
    {
        Assert.That(TitleCaseKata.TitleCase("the quick brown fox"), Is.EqualTo("The Quick Brown Fox"));
    }

    [TestCase("", "", "")]
    [TestCase("a", "a", "A")]
    [TestCase("a fish", "a", "A Fish")]
    [TestCase("a fish tale", "a tale", "A Fish tale")]
    [TestCase("First a of in","an often into","First A Of In")]
    [Order(4)]
    public void MyExtraTest(string sampleTitle, string sampleMinorWords, string expected)
    {
        Assert.That(TitleCaseKata.TitleCase(sampleTitle, sampleMinorWords), Is.EqualTo(expected));
    }
}