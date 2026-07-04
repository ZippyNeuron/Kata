namespace ZippyNeuron.Kata.SumOfTwoLowestIntegers;

public static class SumOfTwoLowestIntegersKata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        (int Index, int Value) first = (0, 0);
        int? second = null;

        for (int i = 0; i < numbers.Length; i++)
            first = i == 0 || numbers[i] < first.Value ? (i, numbers[i]) : first;

        for (int i = 0; i < numbers.Length; i++)
            if (i != first.Index) {
                second = second == null || numbers[i] < second ? numbers[i] : second;
            }

        return first.Value + (second ?? 0);
    }
}