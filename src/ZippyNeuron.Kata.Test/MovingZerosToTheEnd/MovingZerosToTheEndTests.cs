using ZippyNeuron.Kata.MovingZerosToTheEnd;

namespace ZippyNeuron.Kata.Test.MovingZerosToTheEnd;

[TestFixture]
public class MovingZerosToTheEndTests
{
    [Test]
    [Order(1)]
    public void Test()
    {
        int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
        Assert.That(MovingZerosToTheEndKata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(expected));
    }
}
