using System;
using System.Collections.Generic;
using System.Text;

namespace ZippyNeuron.Kata.VowelCount;

public class VowelCountKata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        var vowels = new HashSet<char>([ 'a', 'e', 'i', 'o', 'u' ]);

        foreach (var s in str)
            vowelCount += vowels.Contains(s) ? 1 : 0;

        return vowelCount;
    }
}