namespace ZippyNeuron.Kata.Snail;

public class SnailKata
{
    public static int[] Snail(int[][] array)
    {
        if (array.Length == 0)
            return [];

        static int[] slice(int start, int end, int[] array) =>
            array[start..(end - start == 0 ? end + 1 : end)];

        static void add(int[] array, List<int> result, int size)
        {
            if (result.Count < size)
                result.AddRange(array);
        }

        var size = array.Length * array[0].Length;

        var ranks = new int[array[0].Length][];

        var mid = Math.Min(
            Math.Ceiling(array.Length / 2d),
            Math.Ceiling(array[0].Length / 2d));

        for (int n = array[0].Length - 1; n >= 0; n--)
        {
            ranks[n] = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
                ranks[n][i] = array[i][n];
        }

        List<int> result = [];

        for (int i = 0; i < mid; i++)
        {
            add(slice(i, (array[i].Length - 1) - i, array[i]), result, size);
            add(slice(i, ranks[ranks.Length - 1 - i].Length - 1 - i, ranks[ranks.Length - 1 - i]), result, size);
            add(slice(i, (array[i].Length - 1) - i, [.. array[array.Length - 1 - i].Reverse()]), result, size);
            add(slice(i, ranks[i].Length - 1 - i, [.. ranks[i].Reverse()]), result, size);
        }

        return [.. result];
    }
}