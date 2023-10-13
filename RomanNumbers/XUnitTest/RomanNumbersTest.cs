using RomanNumbersNS;
using Xunit;

namespace TestRomanNumbers;

public class RomanNumbersTest
{
    [Fact]
    public void TestConvert()
    {
        RomanNumbers romanNumbers = new RomanNumbers();
        string actual = romanNumbers.convert(1);
        Assert.NotNull(actual);
        Assert.Equal("I", actual);
        actual = romanNumbers.convert(2);
        Assert.Equal("II", actual);
        actual = romanNumbers.convert(3);
        Assert.Equal("III", actual);
    }
}
