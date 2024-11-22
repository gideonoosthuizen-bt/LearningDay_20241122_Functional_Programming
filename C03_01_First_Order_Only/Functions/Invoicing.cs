using C03_01_First_Order_Only.Models;

namespace C03_01_First_Order_Only.Functions;

public static class Invoicing
{
    public static InvoiceLine Buy(this Product product, int quantity) =>
        new InvoiceLine(product.Name,
            product.UnitPrice.Scale(quantity),
            product.UnitPrice.Scale(quantity).Scale(.20m));
}