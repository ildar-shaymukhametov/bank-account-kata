public class Account
{
    private ITimeProvider timeProvider;

    public Account(ITimeProvider timeProvider)
    {
        this.timeProvider = timeProvider;
    }

    public void Deposit(int amount)
    {
    }

    public void Withdraw(int amount)
    {
    }

    public string Print()
    {
        return null;
    }
}
