﻿

namespace Banking.UnitTests.TestDoubles;
public class DummyBonusCalculator : ICanCalculateBonuses
{


    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountToDeposit)
    {
        throw new NotImplementedException();
    }
}
