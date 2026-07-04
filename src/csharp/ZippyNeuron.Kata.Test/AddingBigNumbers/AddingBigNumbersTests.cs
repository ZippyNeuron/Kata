using ZippyNeuron.Kata.AddingBigNumbers;

namespace ZippyNeuron.Kata.Test.AddingBigNumbers;

public class AddingBigNumbersTests
{
    [Test]
    public void ASimpleKataTest()
    {
        Assert.That(AddingBigNumbersKata.Add("91", "19"), Is.EqualTo("110"));
        Assert.That(AddingBigNumbersKata.Add("123456789", "987654322"), Is.EqualTo("1111111111"));
        Assert.That(AddingBigNumbersKata.Add("999999999", "1"), Is.EqualTo("1000000000"));
    }
}
