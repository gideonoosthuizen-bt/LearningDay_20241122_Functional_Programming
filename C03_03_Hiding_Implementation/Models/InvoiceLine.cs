namespace C03_03_Hiding_Implementation.Models;

public record InvoiceLine
{
    public string Label { get; }
    public Amount BasePrice { get; }
    public Amount Tax { get; }
    public Amount TotalPrice { get; }

    
    public InvoiceLine(string label, Amount basePrice, Amount tax, Func<Amount, Amount, Amount> calculateTotalPrice)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(label, nameof(label));
        ArgumentNullException.ThrowIfNull(basePrice, nameof(basePrice));
        ArgumentNullException.ThrowIfNull(tax, nameof(tax));
        
        Label = label;
        BasePrice = basePrice;
        Tax = tax;

        TotalPrice = calculateTotalPrice(basePrice, tax);
    }
}