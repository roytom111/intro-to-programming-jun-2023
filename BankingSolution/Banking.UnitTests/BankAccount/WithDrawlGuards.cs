public class WithdrawalGuards
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();



        account.WithDrawl(openingBalance + .01M);



        Assert.Equal(openingBalance, account.GetBalance());
    }
}