
namespace StringCalculator;

public class StringCalculatorTests
{
    StringCalculator _calculator = new StringCalculator();
    [Fact]
    public void EmptyStringReturnsZero()
    {

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("118", 118)]
    public void SingleDigit(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("10,8", 18)]
    [InlineData("108,32", 140)]
    public void TwoDigits(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
