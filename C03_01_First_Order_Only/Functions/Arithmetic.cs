using C03_01_First_Order_Only.Models;

namespace C03_01_First_Order_Only.Functions;

public static class Arithmetic
{
    public static Amount Add(this Amount amount, decimal value) =>
        new (amount.Value + value, amount.Currency);

    public static Amount Scale(this Amount unitPrice, decimal factor) =>
        new (unitPrice.Value * factor, unitPrice.Currency);
}