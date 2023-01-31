namespace SolidLessons.LSP.Bad;

public class MicroAccount : BankAccount
{
    private const decimal MaxBalance = 100000M;
    private const decimal MaxWithdrawalAmount = 1000M;
    
    public override decimal Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Amount can not be less then 0");
        }

        if (amount > MaxWithdrawalAmount)
        {
            throw new Exception($"Amount can not be greater then {MaxWithdrawalAmount}");
        }

        Balance -= amount;
        return amount;
    }

    public override decimal Deposit(decimal amount)
    {
        if (Balance + amount > MaxBalance)
        {
            throw new Exception($"Balance exceeds max value ({MaxBalance})");
        }

        Balance += amount;
        return amount;
    }
}