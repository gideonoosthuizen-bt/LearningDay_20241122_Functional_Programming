namespace C03_02_Higher_Order.Models;

public record Product
{
    public string Name { get; }
    public Amount UnitPrice { get; }
    
    public Product(string name, Amount unitPrice)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        ArgumentNullException.ThrowIfNull(unitPrice, nameof(unitPrice));
        
        Name = name;
        UnitPrice = unitPrice;
    }
}