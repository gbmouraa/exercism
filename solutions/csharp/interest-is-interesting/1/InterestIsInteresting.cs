using System.Runtime.CompilerServices;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213f;
        if (balance >= 0 && balance < 1000) return 0.5f;
        if (balance >= 1000 && balance < 5000) return 1.621f;
        return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance / 100 * (decimal)InterestRate(balance);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearCount = 0;
        decimal current = balance;

        while (current < targetBalance)
        {
            current = current + Interest(current);
            yearCount++;
        }

        return yearCount;
    }
}
