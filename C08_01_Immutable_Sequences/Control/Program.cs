﻿using C08_01_Immutable_Sequences.Functions;
using C08_01_Immutable_Sequences.Markers;
using C08_01_Immutable_Sequences.Models;

namespace C08_01_Immutable_Sequences.Control;

class Program
{
    static void Main(string[] args)
    {
        var wallet = new Wallet(new Currency("YEN"), new IMoney[]
        {
            new Cash(new Amount(20m, new Currency("USD"))),
            new GiftCard(new Amount(30m, new Currency("USD")), new DateOnly(2025, 12, 31)),
            new CreditCard(new Month(2025, 12))
        })
        .Add(new Cash(new Amount(35m, new Currency("ZAR"))))
        .With(new Currency("EUR"));;

        var x = wallet.PayableAt(new DateOnly(2024, 11, 22), Expiration.IsExpired());
        var y = wallet.PayableAt(new DateOnly(2027, 1, 1), Expiration.IsExpired());
        
        Console.ReadLine();
    }
}