using ZippyNeuron.Kata.DetectPangram;

namespace ZippyNeuron.Kata.Test.DetectPangram;

public class DetectPangramTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("The quick brown fox jumps over the lazy dog.", true)]
        [TestCase("The quick brown fox jumps over the laxy dog.", false)]
        [TestCase("", false)]
        [TestCase("!a b 1 c2d3e4f5g6h7iJKLMNopQrSTUVw x y z!", true)]
        public void SampleTests(string sentence, bool expectedResult)
        {
            Assert.That(DetectPangramKata.IsPangram(sentence), Is.EqualTo(expectedResult));
        }
    }
}