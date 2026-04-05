namespace ZippyNeuron.Kata.DetectPangram;

public class DetectPangramKata
{
    public static bool IsPangram(string str)
    {
        (int start, int end) = ('a', 'z');
        var tracker = new int[end - start + 1];
        var count = 0;

        foreach (var c in str.ToLower())
        {
            if (c >= start && c <= end && tracker[c - start] == 0)
                tracker[c - start] = ++count;

            if (count == tracker.Length)
                return true;
        }

        return false;
    }
}