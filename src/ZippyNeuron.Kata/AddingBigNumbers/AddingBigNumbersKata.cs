using System.Numerics;

namespace ZippyNeuron.Kata.AddingBigNumbers;

public class AddingBigNumbersKata
{
    public static string Add(string a, string b)
    {
        if (!BigInteger.TryParse(a, out var aValue))
            return "0";
        if (!BigInteger.TryParse(b, out var bValue))
            return "0";

        return (aValue + bValue).ToString();
    }
}