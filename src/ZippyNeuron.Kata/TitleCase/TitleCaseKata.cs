namespace ZippyNeuron.Kata.TitleCase;

public class TitleCaseKata
{
    public static string TitleCase(string title, string minorWords = "")
    {
        var delimiter = ' ';
        var words = title.Split(delimiter);
        var minors = minorWords.ToLowerInvariant().Split(delimiter);
        var outputs = new string[words.Length];

        for(int i = 0; i < words.Length; i++)
        {
            var isMinor = i != 0 && minors.Contains(words[i].ToLower());

            outputs[i] = isMinor
                ? words[i].ToLowerInvariant()
                : words[i].Length > 1
                    ? $"{words[i][..1].ToUpperInvariant()}{words[i][1..].ToLowerInvariant()}"
                    : words[i].ToUpperInvariant();
        }

        return string.Join(delimiter, outputs);
    }
}