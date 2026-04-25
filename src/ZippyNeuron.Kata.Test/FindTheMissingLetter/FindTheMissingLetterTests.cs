using ZippyNeuron.Kata.FindTheMissingLetter;

namespace ZippyNeuron.Kata.Test.FindTheMissingLetter;

[TestFixture]
public class FindTheMissingLetterTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(FindTheMissingLetterKata.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }), Is.EqualTo('e'));
        Assert.That(FindTheMissingLetterKata.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }), Is.EqualTo('P'));
    }
}