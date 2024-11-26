using C08_01_Immutable_Sequences.Extensions;
using C08_01_Immutable_Sequences.Markers;
using C08_01_Immutable_Sequences.Models;

namespace C08_01_Immutable_Sequences.Functions;

public static class Bookkeeping
{
    public static Wallet PayableAt(this Wallet wallet, DateOnly at, Expiration.CheckExpiry checkExpiry) =>
        new(wallet.BaseCurrency, wallet.Monies.PayableAt(at, checkExpiry).AsReiterable());

    public static Wallet With(this Wallet wallet, Currency baseCurrency) => new Wallet(baseCurrency, wallet.Monies.AsReiterable());
    
    public static Wallet Add(this Wallet wallet, IMoney money) => new Wallet(wallet.BaseCurrency, wallet.Monies.Append(money).AsReiterable());
}