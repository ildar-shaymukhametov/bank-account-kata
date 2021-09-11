public class Amount
{
    private int value;

    public Amount(int value)
    {
        this.value = value;
    }

    public static implicit operator Amount(int value) => new Amount(value);
    public static Amount operator +(Amount a, Amount b) => new Amount(a.value + b.value);
    public static Amount operator -(Amount a) => new Amount(-a.value);

    public override string ToString() => value.ToString();
}