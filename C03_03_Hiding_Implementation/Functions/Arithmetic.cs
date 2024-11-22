using C03_03_Hiding_Implementation.Models;

namespace C03_03_Hiding_Implementation.Functions;

public static class Arithmetic
{
    public static Amount Add(this Amount amount, decimal value) =>
        new (amount.Value + value, amount.Currency);

    public static Amount Scale(this Amount unitPrice, decimal factor) =>
        new (unitPrice.Value * factor, unitPrice.Currency);
}