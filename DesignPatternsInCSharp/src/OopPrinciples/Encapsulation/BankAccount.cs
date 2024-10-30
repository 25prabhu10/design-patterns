namespace DesignPatternsInCSharp.src.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }

        balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}