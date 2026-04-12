namespace ZippyNeuron.Kata.SimplePigLatin;

public class SimplePigLatinKata
{
    public static string PigIt(string str)
    {
        var words = str.Split(' ');

        for (int i = 0; i < words.Length; i++)
            if (words[i].Length > 0 && char.IsLetter(words[i][0]))
                words[i] = $"{words[i][1..]}{words[i][..1]}ay";

        return String.Join(' ', words);
    }
}