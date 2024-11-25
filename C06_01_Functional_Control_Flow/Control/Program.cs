using C06_01_Functional_Control_Flow.Functions;
using C06_01_Functional_Control_Flow.Models;

namespace C06_01_Functional_Control_Flow.Control;

class Program
{
    static void Main(string[] args)
    {
        var giftCard = new GiftCard(new Amount(100m, new Currency("USD")), new DateOnly(2025, 12, 31));
        var creditCard = new CreditCard(new Month(2025, 12));
        var cash = new Cash(new Amount(50m, new Currency("EUR")));

        var now = DateTime.Now;
        var today = new DateOnly(now.Year, now.Month, now.Day);
        var nextCentury = today.AddYears(100);
        
        var x1 = cash.PayableAt(today, Expiration.IsExpired());
        var y1 = giftCard.PayableAt(today, Expiration.IsExpired());
        var z1 = creditCard.PayableAt(today, Expiration.IsExpired());
        
        var x2 = cash.PayableAt(nextCentury, Expiration.IsExpired());
        var y2 = giftCard.PayableAt(nextCentury, Expiration.IsExpired());
        var z2 = creditCard.PayableAt(nextCentury, Expiration.IsExpired());

        var bp = "BP";
    }
}