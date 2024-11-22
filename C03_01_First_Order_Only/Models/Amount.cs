namespace C03_01_First_Order_Only.Models;

public record Amount
{
    public decimal Value { get; }
    public Currency Currency { get; }
        
    public Amount(decimal value, Currency currency)
    {
        ArgumentNullException.ThrowIfNull(currency, nameof(currency));
            
        Value = value;
        Currency = currency;
    }
}