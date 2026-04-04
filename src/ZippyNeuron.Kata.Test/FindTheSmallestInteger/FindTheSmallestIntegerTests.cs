using ZippyNeuron.Kata.FindTheSmallestInteger;

namespace ZippyNeuron.Kata.Tests.FindTheSmallestInteger
{
    [TestFixture]
    public class FindTheSmallestIntegerTests
    {
        [Test]
        [Order(1)]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public static int FindTheSmallestInteger(int[] args)
        {
            return FindTheSmallestIntegerKata.FindSmallestInt(args);
        }
    }
}