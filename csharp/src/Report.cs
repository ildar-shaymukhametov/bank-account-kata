internal class Report
{
    private Transaction item;
    private Amount balance;

    public Report(Transaction item, Amount balance)
    {
        this.item = item;
        this.balance = balance;
    }

    public string GetPrintString()
    {
        return $"{item.GetDateString("dd/MM/yyyy")} || {item.GetAmount()}   || {balance}";
    }
}