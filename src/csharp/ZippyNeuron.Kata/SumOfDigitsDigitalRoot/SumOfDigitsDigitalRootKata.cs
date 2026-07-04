using System.Net.WebSockets;

namespace ZippyNeuron.Kata.SumOfDigitsDigitalRoot;

public class SumOfDigitsDigitalRootKata
{
    public static int DigitalRoot(long n)
    {
        var total = 0;

        foreach (char number in n.ToString())
            total += number - '0';

        if (total > 9)
            return DigitalRoot(total);

        return total;
    }
}