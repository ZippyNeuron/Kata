namespace ZippyNeuron.Kata.MovingZerosToTheEnd;

public class MovingZerosToTheEndKata
{
    public static int[] MoveZeroes(int[] arr)
    {
        var result = new int[arr.Length];
        var count = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                result[count] = arr[i];
                count++;
            }
        }

        return result;
    }
}