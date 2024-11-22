namespace C03_02_Higher_Order.Models;

public record Currency
{
    public string Symbol { get; }
        
    public Currency(string symbol)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));
            
        Symbol = symbol;
    }
}