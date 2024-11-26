using C08_02_Immutable_Collections.Models;

namespace C08_02_Immutable_Collections.Functions;

public static class Arithmetic
{
    public static Amount Add(this Amount amount, decimal value) =>
        new (amount.Value + value, amount.Currency);
    
    public static Amount Scale(this Amount unitPrice, decimal factor) =>
        new (unitPrice.Value * factor, unitPrice.Currency);
    
    public static Amount Subtract(this Amount amount, decimal value) =>
        new (amount.Value - value, amount.Currency);

    public static (Amount Final, Amount Difference) Subtract(this Amount amount, Amount other) => other switch
    {
        // Success: Currencies match and the amount is greater than the other amount
        { Currency: { } currency } when amount.Currency == currency && amount.Value >= other.Value =>
            (new(amount.Value - other.Value, amount.Currency), new (other.Value, amount.Currency)),
        
        // Partial success: Currencies match but the amount is less than the other amount
        { Currency: { } currency } when amount.Currency == currency =>
            (new(amount.Value, amount.Currency), amount.Currency.Zero),
        
        // Failure: Currencies do not match
        _ => throw new InvalidOperationException($"Cannot subtract amounts ({amount} - {other}) because they have different currencies.")

    };
}