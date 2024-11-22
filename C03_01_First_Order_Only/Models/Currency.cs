namespace C03_01_First_Order_Only.Models;

public record Currency
{
    public string Symbol { get; }
        
    public Currency(string symbol)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));
            
        Symbol = symbol;
    }
}