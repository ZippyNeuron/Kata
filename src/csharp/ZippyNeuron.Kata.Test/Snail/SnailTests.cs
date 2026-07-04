using ZippyNeuron.Kata.Snail;

namespace ZippyNeuron.Kata.Test.Snail;

[TestFixture]
public class SnailTests
{
    [Test, Order(1)]
    public void SnailTest1()
    {
        int[][] array =
        {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
        };

        var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        var x = SnailKata.Snail(array);

        Test(array, r);
    }

    [Test, Order(2)]
    public void SnailTest2()
    {
        int[][] array =
        {
            [1, 3],
            [9, 6]
        };

        var r = new[] { 1, 3, 6, 9 };

        Test(array, r);
    }

    [Test, Order(3)]
    public void SnailTest3()
    {
        int[][] array =
        {
           [1,  2,  3,  4],
           [10, 11, 12,  5],
           [ 9,  8,  7,  6]
        };

        var r = Enumerable.Range(1, 12).ToArray();

        Test(array, r);
    }


    [Test, Order(4)]
    public void SnailTest4()
    {
        int[][] array =
        {
            [ 1,   2,   3,   4,   5,   6,   7,   8],
            [28,  29,  30,  31,  32,  33,  34,   9],
            [27,  48,  49,  50,  51,  52,  35,   10],
            [26,  47,  60,  61,  62,  53,  36,   11],
            [25,  46,  59,  64,  63,  54,  37,   12],
            [24,  45,  58,  57,  56,  55,  38,   13],
            [23,  44,  43,  42,  41,  40,  39,   14],
            [22,  21,  20,  19,  18,  17,  16,   15],
        };

        var r = Enumerable.Range(1, 64).ToArray();

        Test(array, r);
    }

    public string Int2dToString(int[][] a)
    {
        return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
    }

    public void Test(int[][] array, int[] result)
    {
        Assert.That(SnailKata.Snail(array), Is.EqualTo(result));
    }
}