using System.Collections.Immutable;
using C08_02_Immutable_Collections.Extensions;
using C08_02_Immutable_Collections.Markers;
using C08_02_Immutable_Collections.Models;

namespace C08_02_Immutable_Collections.Functions;

public static class Bookkeeping
{
    public static Wallet PayableAt(this Wallet wallet, DateOnly at, Expiration.CheckExpiry checkExpiry) =>
        new(wallet.BaseCurrency, wallet.Monies.PayableAt(at, checkExpiry).ToImmutableList());

    public static Wallet With(this Wallet wallet, Currency baseCurrency) => new Wallet(baseCurrency, wallet.Monies);
    
    public static Wallet Add(this Wallet wallet, IMoney money) => new Wallet(wallet.BaseCurrency, wallet.Monies.Add(money));
}