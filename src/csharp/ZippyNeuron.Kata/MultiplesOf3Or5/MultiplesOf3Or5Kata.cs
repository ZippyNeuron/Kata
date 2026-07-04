namespace ZippyNeuron.Kata.MultiplesOf3Or5;

public class MultiplesOf3Or5Kata
{
    public static int Solution(int value)
    {
        if (value < 0)
            return 0;

        var result = 0;

        for (int i = 1; i < value; i++)
            result += i % 3 == 0 ? i : i % 5 == 0 ? i : 0;

        return result;
    }
}