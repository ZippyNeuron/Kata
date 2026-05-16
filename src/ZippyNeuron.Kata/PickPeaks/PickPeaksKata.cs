namespace ZippyNeuron.Kata.PickPeaks;

public class PickPeaksKata
{
    private const string PositionKey = "pos";
    private const string PeaksKey = "peaks";

    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        var result = new Dictionary<string, List<int>>()
        {
            { PositionKey, new List<int>() },
            { PeaksKey, new List<int>() }
        };

        var peaks = new List<(int position, int peak)>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i - 1] == arr[i])
                continue;

            peaks.Add((i, arr[i]));
        }

        if (peaks.Count < 3)
            return result;

        for (int i = 1; i < peaks.Count - 1; i++)
        {
            if (peaks[i - 1].peak < peaks[i].peak && peaks[i + 1].peak < peaks[i].peak)
            {
                result[PositionKey].Add(peaks[i].position);
                result[PeaksKey].Add(peaks[i].peak);
            }
        }

        return result;
    }
}