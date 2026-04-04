using ZippyNeuron.Kata.Tribonacci;

namespace ZippyNeuron.Kata.Test.Tribonacci;

[TestFixture]
public class TribonacciTest
{
    private TribonacciKata tribonacciKata;

    [SetUp]
    public void SetUp()
    {
        tribonacciKata = new TribonacciKata();
    }

    [TearDown]
    public void TearDown()
    {
        tribonacciKata = null!;
    }

    [Test]
    public void GetTribonacci()
    {
        Assert.That(tribonacciKata.Tribonacci(new double[] { 1, 1, 1 }, 1), Is.EqualTo(new double[] { 1 }));
        Assert.That(tribonacciKata.Tribonacci(new double[] { 16, 17, 2 }, 0), Is.EqualTo(new double[] { }));
        Assert.That(tribonacciKata.Tribonacci(new double[] { 1, 1, 1 }, 10), Is.EqualTo(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }));
        Assert.That(tribonacciKata.Tribonacci(new double[] { 0, 0, 1 }, 10), Is.EqualTo(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }));
        Assert.That(tribonacciKata.Tribonacci(new double[] { 0, 1, 1 }, 10), Is.EqualTo(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }));
    }
}
