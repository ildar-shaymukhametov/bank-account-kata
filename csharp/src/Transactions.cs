public class Transactions
{
    private readonly List<Transaction> items;

    public Transactions()
    {
        this.items = new List<Transaction>();
    }

    internal void Add(Transaction transaction)
    {
        this.items.Add(transaction);
    }

    internal List<Report> GetReport()
    {
        var result = new List<Report>();
        var balance = new Amount(0);
        foreach (var item in items)
        {
            result.Add(new Report(item, balance += item.GetAmount()));
        }
        result.Reverse();

        return result;
    }
}