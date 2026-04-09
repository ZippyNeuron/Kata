using ZippyNeuron.Kata.MultiplesOf3Or5;

namespace ZippyNeuron.Kata.Test.MultiplesOf3Or5;

[TestFixture]
public class MultiplesOf3Or5Tests
{
    [Test]
    public void SampleTests()
    {
        Assertion(expected: 23, input: 10);
        Assertion(expected: 78, input: 20);
        Assertion(expected: 9168, input: 200);
        Assertion(expected: 0, input: 0);
    }

    private static void Assertion(int expected, int input) =>
      Assert.That(
        MultiplesOf3Or5Kata.Solution(input),
        Is.EqualTo(expected),
        $"Incorrect answer for input={input}"
      );
}
