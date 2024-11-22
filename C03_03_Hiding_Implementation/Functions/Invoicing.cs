using C03_03_Hiding_Implementation.Extensions;
using C03_03_Hiding_Implementation.Models;

namespace C03_03_Hiding_Implementation.Functions;

public static class Invoicing
{
    private static (Amount BasePrice, Amount Tax) _calculatePriceSpecification(this Product product, int quantity, Func<Amount, Amount> taxFor) =>
        product.UnitPrice.Scale(quantity)
            .Map(basePrice => (BasePrice: basePrice, Tax: taxFor(basePrice)));

    private static Amount _calculateTotalPrice(Amount basePrice, Amount tax) => basePrice.Add(tax.Value);
    
    public static InvoiceLine Buy(this Product product, int quantity, Func<Amount, Amount> taxFor) => product
        ._calculatePriceSpecification(quantity, taxFor)
        .Map(specification => new InvoiceLine(product.Name, specification.BasePrice, specification.Tax, _calculateTotalPrice));
    
    public static Func<int, Amount> PriceFor(this Product product, Func<Amount, Amount> taxFor) =>
        quantity => product
            ._calculatePriceSpecification(quantity, taxFor)
            .Map(specification => _calculateTotalPrice(specification.BasePrice, specification.Tax));
}