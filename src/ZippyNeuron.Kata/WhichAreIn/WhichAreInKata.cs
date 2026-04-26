namespace ZippyNeuron.Kata.WhichAreIn;

public class WhichAreInKata
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        var results = new HashSet<string>();

        Array.Sort(array1);

        foreach(var a1 in array1)
        {
            foreach (var a2 in array2)
            {
                if (a2.IndexOf(a1) > -1)
                {
                    results.Add(a1);
                    break;
                }
            }
        }

        return [..results];
    }
}