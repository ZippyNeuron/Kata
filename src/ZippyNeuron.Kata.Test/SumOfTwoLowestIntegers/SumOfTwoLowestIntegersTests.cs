using ZippyNeuron.Kata.SumOfTwoLowestIntegers;

namespace ZippyNeuron.Kata.Test.SumOfTwoLowestIntegers;

[TestFixture]
public class SumOfTwoLowestIntegersTests
{
    [Test, Order(1)]
    public void Test1()
    {
        int[] numbers = { 5, 8, 12, 19, 22 };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(13));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] numbers = { 19, 5, 42, 2, 77 };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(7));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] numbers = { 10, 343445353, 3453445, 2147483647 };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(3453455));
    }

    [Test, Order(4)]
    public void Test4()
    {
        int[] numbers = { };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(0));
    }

    [Test, Order(5)]
    public void Test5()
    {
        int[] numbers = { 2 };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(2));
    }

    [Test, Order(5)]
    public void Test6()
    {
        int[] numbers = { 2, 3 };
        Assert.That(SumOfTwoLowestIntegersKata.sumTwoSmallestNumbers(numbers), Is.EqualTo(5));
    }
}