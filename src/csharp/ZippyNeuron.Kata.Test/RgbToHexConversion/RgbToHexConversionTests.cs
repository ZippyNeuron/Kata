using ZippyNeuron.Kata.RgbToHexConversion;

namespace ZippyNeuron.Kata.Test.RgbToHexConversion;

[TestFixture]
public class RgbToHexConversionTests
{
    [Test]
    [Order(1)]
    public void FixedTests()
    {
        Assert.That(RgbToHexConversionKata.Rgb(127, 127, 127), Is.EqualTo("7F7F7F"));
        Assert.That(RgbToHexConversionKata.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
        Assert.That(RgbToHexConversionKata.Rgb(255, 255, 300), Is.EqualTo("FFFFFF"));
        Assert.That(RgbToHexConversionKata.Rgb(0, 0, 0), Is.EqualTo("000000"));
        Assert.That(RgbToHexConversionKata.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
        Assert.That(RgbToHexConversionKata.Rgb(148, -20, 211), Is.EqualTo("9400D3"), "Handle negative numbers.");
        Assert.That(RgbToHexConversionKata.Rgb(144, 195, 212), Is.EqualTo("90C3D4"));
        Assert.That(RgbToHexConversionKata.Rgb(212, 53, 12), Is.EqualTo("D4350C"), "Consider single hex digit numbers.");
    }
}