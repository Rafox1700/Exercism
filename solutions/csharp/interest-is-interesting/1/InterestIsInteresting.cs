using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
        => balance switch
        {
                < 0m => 3.213f,
                < 1000m => 0.5f,
                < 5000m => 1.621f,
                _ => 2.475f
        };

    public static decimal Interest(decimal balance)
        => (decimal)InterestRate(balance)*balance / 100m;

    public static decimal AnnualBalanceUpdate(decimal balance)
        => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsBeforeDesiredBalance = 0;
        
        if (balance >= targetBalance)
        {
            return yearsBeforeDesiredBalance;
        }
        
        do
        {
            balance = AnnualBalanceUpdate(balance);
            yearsBeforeDesiredBalance++;
        }
        while (balance < targetBalance);

        return yearsBeforeDesiredBalance;
    }
}
