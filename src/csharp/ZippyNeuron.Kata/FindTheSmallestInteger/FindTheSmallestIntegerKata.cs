namespace ZippyNeuron.Kata.FindTheSmallestInteger;

public class FindTheSmallestIntegerKata
{
    public static int FindSmallestInt(int[] args)
    {
        int smallest = args.Length > 0 ? args[0] : 0;

        foreach (int i in args)
            smallest = i < smallest ? i : smallest;

        return smallest;
    }
}