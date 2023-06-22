
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("", "");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("1", "2", 3)]
    [InlineData("2","3",5)]
    [InlineData("3","4",7)] 
    public void ReturnTwoString(string num,string num2,int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(num,num2);

        Assert.Equal(expected, result);
    }


}
