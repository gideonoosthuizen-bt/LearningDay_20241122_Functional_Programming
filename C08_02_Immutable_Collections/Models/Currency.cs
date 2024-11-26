namespace C08_02_Immutable_Collections.Models;

public record struct Currency
{
    public string Symbol { get; }

    public Currency(string symbol)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));

        Symbol = symbol;
    }

    public Amount Zero => new(0, this);

    public override string ToString() => $"{Symbol}";
}