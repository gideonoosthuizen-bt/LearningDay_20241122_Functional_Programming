using C06_01_Functional_Control_Flow.Common;
using C06_01_Functional_Control_Flow.Markers;
using C06_01_Functional_Control_Flow.Models;

namespace C06_01_Functional_Control_Flow.Functions;

public static class Settlement
{
    public static Option<IMoney> PayableAt(this IMoney money, DateOnly date, Expiration.CheckExpiry checkExpiry) => money switch
    {
        Cash cash => cash,

        GiftCard giftCard when !checkExpiry(giftCard.ValidUntil, date) => giftCard,
        CreditCard creditCard when !checkExpiry(creditCard.ValidUntil, date) => creditCard,

        _ => None.Value
    };
}