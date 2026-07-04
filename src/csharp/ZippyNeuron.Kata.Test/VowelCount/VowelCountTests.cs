using ZippyNeuron.Kata.VowelCount;

namespace ZippyNeuron.Kata.Test.VowelCount;

[TestFixture]
public class VowelCountTests
{
    [TestCase("abracadabra", 5)]
    [TestCase("faskjfwioiplskjdlkfuslkdwnenwnccxsdlkfjleuopiqkjasdkfmabsdvasu", 14)]
    public void GetVowelCount(string value, int vowelCount)
    {
        Assert.That(VowelCountKata.GetVowelCount(value), Is.EqualTo(vowelCount), $"Incorrect answer for str = \"{value}\"");
    }
}