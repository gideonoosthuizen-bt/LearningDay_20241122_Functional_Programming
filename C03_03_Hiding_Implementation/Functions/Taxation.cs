using C03_03_Hiding_Implementation.Models;

namespace C03_03_Hiding_Implementation.Functions;

public static class Taxation
{
    private static decimal _getDefaultTaxRate() => .20m;
    
    private static Amount _applyTax(this Amount basePrice, decimal taxRate) =>
        new(basePrice.Value * taxRate, basePrice.Currency);
    
    public static Func<Amount, Amount> TaxFor(this Product product) => basePrice =>
        basePrice._applyTax(product switch
        {
            _ => _getDefaultTaxRate()
        });
}