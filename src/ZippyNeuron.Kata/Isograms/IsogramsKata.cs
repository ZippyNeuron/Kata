namespace ZippyNeuron.Kata.Isograms;

public class IsogramsKata
{
    public static bool IsIsogram(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return true;

        (int start, int end) = ('a', 'z');

        var tracker = new int[end - start + 1];

        foreach (var c in str.ToLower())
        {
            if (c < start && c > end || tracker[c - start] > 0)
                return false;

            tracker[c - start]++;
        }

        return true;
    }
}