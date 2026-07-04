using ZippyNeuron.Kata.SimplePigLatin;

namespace ZippyNeuron.Kata.Test.SimplePigLatin;

[TestFixture]
public class SimplePigLatinTests
{
    [Test]
    public void KataTests()
    {
        Assert.That(SimplePigLatinKata.PigIt("Hello world !"), Is.EqualTo("elloHay orldway !"));
        Assert.That(SimplePigLatinKata.PigIt("P"), Is.EqualTo("Pay"));
        Assert.That(SimplePigLatinKata.PigIt("Pay"), Is.EqualTo("ayPay"));
        Assert.That(SimplePigLatinKata.PigIt("A small collection of a e i o u"), Is.EqualTo("Aay mallsay ollectioncay foay aay eay iay oay uay"));
        Assert.That(SimplePigLatinKata.PigIt("Pig latin is cool"), Is.EqualTo("igPay atinlay siay oolcay"));
        Assert.That(SimplePigLatinKata.PigIt("This is my string"), Is.EqualTo("hisTay siay ymay tringsay"));
    }
}