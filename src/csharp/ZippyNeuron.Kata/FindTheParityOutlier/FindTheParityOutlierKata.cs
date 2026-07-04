namespace ZippyNeuron.Kata.FindTheParityOutlier;

public class FindTheParityOutlierKata
{
    public static int Find(int[] integers)
    {
        (int Index, int Number) odd = (-1, 0);
        (int Index, int Number) even = (-1, 0);
        (int Index, int Number) other = (-1, 0);

        for (int i = 0; i < integers.Length; i++)
        {
            odd = odd.Index == -1 && integers[i] % 2 != 0
                ? (i, integers[i])
                : odd;

            even = even.Index == -1 && integers[i] % 2 == 0
                ? (i, integers[i])
                : even;

            other = i != odd.Index && i != even.Index
                ? (i, integers[i])
                : other;

            if (odd.Index != -1 && even.Index != -1 && other.Index != -1)
                return other.Number % 2 != 0
                    ? even.Number
                    : odd.Number;
        }

        return -1;
    }
}