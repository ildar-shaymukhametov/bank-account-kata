using System.Text;

public class Account
{
    private ITimeProvider timeProvider;
    private Transactions transactions;

    public Account(ITimeProvider timeProvider)
    {
        this.timeProvider = timeProvider;
        this.transactions = new Transactions();
    }

    public void Deposit(Amount amount)
    {
        AddTransaction(amount);
    }

    public void Withdraw(Amount amount)
    {
        AddTransaction(-amount);
    }

    private void AddTransaction(Amount amount)
    {
        this.transactions.Add(new Transaction(amount, timeProvider.Now()));
    }

    public string Print()
    {
        var result = new StringBuilder();
        result.AppendLine(GetHeader());
        result.Append(GetBody());
        return result.ToString();
    }

    private string GetBody()
    {
        return string.Join('\n', GetReportStrings());
    }

    private IEnumerable<string> GetReportStrings()
    {
        return this.transactions.GetReport().Select(x => x.GetPrintString());
    }

    private static string GetHeader()
    {
        return "Date       || Amount || Balance";
    }
}
