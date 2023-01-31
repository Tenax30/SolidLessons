namespace SolidLessons.LSP.Bad;

public abstract class BankAccount
{
    private const decimal MaxBalance = 1000000000M;
    public decimal Balance { get; protected set; }
    
    public virtual decimal Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Amount can not be less then 0");
        }
        
        Balance -= amount;
        return amount;
    }

    public virtual decimal Deposit(decimal amount)
    {
        var bonus = CalculateBonus(amount);
        var totalAmount = amount + bonus;

        if (Balance + totalAmount > MaxBalance)
        {
            throw new Exception($"Balance exceeds max value ({MaxBalance})");
        }
        
        Balance += totalAmount;
        return totalAmount;
    }

    private static decimal CalculateBonus(decimal amount) => Math.Round(amount / 1000);
}