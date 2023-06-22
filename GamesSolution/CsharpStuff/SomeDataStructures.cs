

namespace CsharpStuff;

public class SomeDataStructures
{
    [Fact]
    public void Classes()
    {
        var MyAccount = new BankAccount();
        Assert.Equal(5000M, MyAccount.GetBalance());

        var YourAccount = new BankAccount();
        Assert.Equal(5000M, MyAccount.GetBalance());

        MyAccount.Deposit(100M);

        Assert.Equal(5100M, MyAccount.GetBalance());
        Assert.Equal(5000M, MyAccount.GetBalance());


    }
    [Fact]
    public void ClassesHaveSomeDataAttachedToThem() 
    {
        var MyAccount = new BankAccount();
        MyAccount.Email = "yoimhere@gmail.com";

        
    }
    [Fact]

    public void Tupeles() 
    { 
    }

    [Fact] 
    public void Structs() 
    {
        
    }
}
