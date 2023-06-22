

namespace CsharpStuff;

public class BankAccount
{

    private decimal _balance = 5000M;
    private string _email = "";


    public string Email 
    { get { return _email; }
      set { _email = value; }
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
