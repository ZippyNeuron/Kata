namespace ZippyNeuron.Kata.HumanReadableTime;

public class HumanReadableTimeKata
{
    public static string GetReadableTime(int seconds)
    {
        var h = seconds / 3600;
        var m = seconds % 3600 / 60;
        var s = seconds % 60;

        return $"{h:D2}:{m:D2}:{s:D2}";
    }
}