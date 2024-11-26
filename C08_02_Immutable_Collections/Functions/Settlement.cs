using C08_02_Immutable_Collections.Common;
using C08_02_Immutable_Collections.Extensions;
using C08_02_Immutable_Collections.Markers;
using C08_02_Immutable_Collections.Models;

namespace C08_02_Immutable_Collections.Functions;

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
        monies.All(money => money._isPayableAt(at, checkExpiry))
            ? monies
            : monies.SelectOptional(money => _payableAt(money, at, checkExpiry));
}