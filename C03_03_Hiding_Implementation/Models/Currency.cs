namespace C03_03_Hiding_Implementation.Models;

public record Currency
{
    public string Symbol { get; }
        
    public Currency(string symbol)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));
            
        Symbol = symbol;
    }
}