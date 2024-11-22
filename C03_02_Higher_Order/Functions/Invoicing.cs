using C03_02_Higher_Order.Extensions;
using C03_02_Higher_Order.Models;

namespace C03_02_Higher_Order.Functions;

public static class Invoicing
{
    private static (Amount BasePrice, Amount Tax) _calculatePriceSpecification(this Product product, int quantity) =>
        product.UnitPrice.Scale(quantity)
            .Map(basePrice => (BasePrice: basePrice, Tax: Arithmetic.Scale(basePrice, .20m)));

    public static InvoiceLine Buy(this Product product, int quantity) => product
        ._calculatePriceSpecification(quantity)
        .Map(specification => new InvoiceLine(product.Name, specification.BasePrice, specification.Tax));
    
    public static Func<int, Amount> PriceFor(this Product product) =>
        quantity => product
            ._calculatePriceSpecification(quantity)
            .Map(specification => specification.BasePrice.Add(specification.Tax.Value));
}