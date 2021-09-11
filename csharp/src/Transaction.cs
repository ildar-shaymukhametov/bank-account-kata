internal class Transaction
{
    private Amount amount;
    private DateTime dateTime;

    public Transaction(Amount amount, DateTime dateTime)
    {
        this.amount = amount;
        this.dateTime = dateTime;
    }

    internal DateTime GetDate()
    {
        return dateTime;
    }

    internal string GetDateString(string format)
    {
        return dateTime.ToString(format);
    }

    internal Amount GetAmount()
    {
        return amount;
    }
}