﻿namespace C06_01_Functional_Control_Flow.Models;

public record struct Amount
{
    public decimal Value { get; }
    public Currency Currency { get; }
        
    public Amount(decimal value, Currency currency)
    {
        ArgumentNullException.ThrowIfNull(currency, nameof(currency));
            
        Value = value;
        Currency = currency;
    }

    public override string ToString() => $"{Value:0.00} [{Currency}]";
}