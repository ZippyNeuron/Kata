using System.Diagnostics;

namespace ZippyNeuron.Kata.Tribonacci;

public class TribonacciKata
{
    public double[] Tribonacci(double[] signature, int n)
    {
        var length = signature.Length;

        if (n < length)
            return signature[..n];

        var result = new double[n];

        Array.Copy(signature, result, length);
        
        for (int i = 0; i < n - length; i++)
        {
            for (int s = 0; s < length; s++)
            {
                result[length + i] += result[s + i];
            }
        }

        return result[..n];
    }
}