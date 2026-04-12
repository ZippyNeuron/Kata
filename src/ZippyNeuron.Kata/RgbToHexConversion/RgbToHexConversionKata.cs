using System.Reflection.Metadata.Ecma335;

namespace ZippyNeuron.Kata.RgbToHexConversion;

public class RgbToHexConversionKata
{
    public static string Rgb(int r, int g, int b)
    {
        var clamp = (int v) => 
            v < 0 ? 0 : v > 255 ? 255 : v;

        return $"{clamp(r):X2}{clamp(g):X2}{clamp(b):X2}";
    }
}