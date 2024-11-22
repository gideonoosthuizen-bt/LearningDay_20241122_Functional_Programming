using C08_01_Immutable_Sequences.Common;
using C08_01_Immutable_Sequences.Extensions;
using C08_01_Immutable_Sequences.Markers;
using C08_01_Immutable_Sequences.Models;

namespace C08_01_Immutable_Sequences.Functions;

public static class Settlement
{
    private static bool _isPayableAt(this IMoney money, DateOnly date, Expiration.CheckExpiry checkExpiry) => money switch
    {
        Cash _ => true,

        GiftCard giftCard => !checkExpiry(giftCard.ValidUntil, date),
        CreditCard creditCard => !checkExpiry(creditCard.ValidUntil, date),

        _ => false
    };

    private static Option<IMoney> _payableAt(this IMoney money, DateOnly date, Expiration.CheckExpiry checkExpiry) =>
        money._isPayableAt(date, checkExpiry)
            ? new Some<IMoney>(money)
            : None.Value;

    public static IEnumerable<IMoney> PayableAt(this IEnumerable<IMoney> monies, DateOnly at, Expiration.CheckExpiry checkExpiry) =>
        monies.SelectOptional(money => money._payableAt(at, checkExpiry));
}