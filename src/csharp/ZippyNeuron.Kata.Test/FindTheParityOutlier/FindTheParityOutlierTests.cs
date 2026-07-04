using ZippyNeuron.Kata.FindTheParityOutlier;

namespace ZippyNeuron.Kata.Test.FindTheParityOutlier;

[TestFixture]
internal class FindTheParityOutlierTests
{
    private static void DoTest(int expected, int[] input)
    {
        String message = "for array { " + string.Join(", ", input) + " }\n";
        int actual = FindTheParityOutlierKata.Find(input);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    [Order(1)]
    public static void Test1()
    {
        DoTest(3, new int[] { 2, 6, 8, -10, 3 });
    }

    [Test]
    [Order(2)]
    public static void Test2()
    {
        DoTest(206847684, new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 });
    }

    [Test]
    [Order(3)]
    public static void Test3()
    {
        DoTest(0, new int[] { int.MaxValue, 0, 1 });
    }

    [Test]
    [Order(4)]
    public static void Test4()
    {
        DoTest(-5, new int[] { -5, 6, 6 });
    }

    [Test]
    [Order(1)]
    public static void Test5()
    {
        DoTest(-1, new int[] { });
    }

    [Test]
    [Order(1)]
    public static void Test6()
    {
        DoTest(-1, new int[] { 1 });
    }

    [Test]
    [Order(1)]
    public static void Test7()
    {
        DoTest(-1, new int[] { 1, 2 });
    }

    [Test]
    [Order(1)]
    public static void Test8()
    {
        DoTest(2, new int[] { 1, 2, 3 });
    }

    [Test]
    [Order(1)]
    public static void Test9()
    {
        DoTest(-1, new int[] { 1, 5, 3 });
    }

    [Test]
    [Order(1)]
    public static void Test10()
    {
        DoTest(-1, new int[] { 2, 4, 8 });
    }
}