

using System.Xml.Linq;
using Xunit.Sdk;

namespace Greeter.UnitTests;
public class GreetingTests
{
    [Theory]
    [InlineData("Windom", "Hello, Windom")]
    [InlineData("Boy", "Hello, Boy")]

    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    [Theory]

    [InlineData(null, "Hello, Chief")]
    public void Nulls(string? name, string expected )
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);

    }
    [Theory]
    [InlineData("BOB","HELLO, BOB!" )]

    public void Shout(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);

    }
    [Theory]
    [InlineData("Bob", "Sue", "Hello, Bob and Sue!")]

    public void TwoNames(string name,string name2, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name, name2);

        Assert.Equal(expected, greeting);



    }
    [Theory]
    [InlineData ("Cooper", "Rosenfield", "Preston", "Milford!")]

    public void ArbitaryNames(params string[] names)
    {

        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(String.Join(", ", names));

        Assert.Equal("Hello, Cooper, Rosenfield, Preston, Milford!", greeting);

    }
}   
