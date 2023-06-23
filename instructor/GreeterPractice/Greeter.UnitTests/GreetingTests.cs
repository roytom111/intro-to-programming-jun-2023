

namespace Greeter.UnitTests;
public class GreetingTests
{
    [Theory]
    [InlineData("Windom", "Hello, Windom.")]
    [InlineData("Cooper", "Hello, Cooper.")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name) ;

        Assert.Equal(expected, greeting);
    }
}
