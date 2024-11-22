using C03_02_Higher_Order.Models;

namespace C03_02_Higher_Order.Functions;

public static class Arithmetic
{
    public static Amount Add(this Amount amount, decimal value) =>
        new (amount.Value + value, amount.Currency);

    public static Amount Scale(this Amount unitPrice, decimal factor) =>
        new (unitPrice.Value * factor, unitPrice.Currency);
}