

namespace Banking.UnitTests.BankAccount;

public class MakingWithDrawls
{
    [Fact]
    public void MakingAWithdrawlDecreasesTheBalance()
    {
        // Given 
        // If I have an account and I want to deposit 100
        Account account = new Account();
        decimal openingBalance = account.GetBalance(); // Query
        decimal amountToWithDrawl = 100M;



        // When - I do the deposit
        account.WithDrawl(amountToWithDrawl); // "Command"



        // Then - I can verify it worked if the new balance is 100 more than the balance
        //        was before.
        Assert.Equal(openingBalance - amountToWithDrawl, account.GetBalance());
    }
    [Fact]
    public void CanTakeFullBalance()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();



        account.WithDrawl(openingBalance);



        Assert.Equal(0, account.GetBalance());
    }
}
