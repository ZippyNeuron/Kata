using System.Text;

namespace ZippyNeuron.Kata.WeIrDStRiNgCaSe;

// https://www.codewars.com/kata/52b757663a95b11b3d00062d/train/csharp

public class WeIrDStRiNgCaSeKata
{
    public static string ToWeirdCase(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        var result = new char[s.Length];
        var index = 0;

        for(int i = 0; i < s.Length; i++)
        {
            result[i] = index % 2 != 0 ? Char.ToLowerInvariant(s[i]) : Char.ToUpperInvariant(s[i]);

            index++;

            if (s[i] == ' ')
                index = 0;
        }

        return new string(result);
    }
}