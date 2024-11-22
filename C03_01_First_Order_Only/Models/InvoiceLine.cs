using C03_01_First_Order_Only.Functions;

namespace C03_01_First_Order_Only.Models;

public record InvoiceLine
{
    public string Label { get; }
    public Amount BasePrice { get; }
    public Amount Tax { get; }
    public Amount TotalPrice => BasePrice.Add(Tax.Value);
    
    public InvoiceLine(string label, Amount basePrice, Amount tax)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(label, nameof(label));
        ArgumentNullException.ThrowIfNull(basePrice, nameof(basePrice));
        ArgumentNullException.ThrowIfNull(tax, nameof(tax));
        
        Label = label;
        BasePrice = basePrice;
        Tax = tax;
    }
}