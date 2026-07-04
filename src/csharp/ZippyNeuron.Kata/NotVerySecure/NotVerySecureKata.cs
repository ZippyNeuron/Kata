namespace ZippyNeuron.Kata.NotVerySecure;

public class NotVerySecureKata
{
    public static bool Alphanumeric(string str)
    {
        if (str.Length == 0)
            return false;

        var allowed = new HashSet<char>(
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890");

        foreach (char c in str)
        {
            if (!allowed.Contains(c))
                return false;
        }

        return true;
    }
}