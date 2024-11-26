using C08_02_Immutable_Collections.Markers;

namespace C08_02_Immutable_Collections.Models;

public record CreditCard : IMoney
{
    public DateOnly ValidUntil { get; }

    public CreditCard(Month validThru)
    {
        ValidUntil = ((DateOnly)validThru).AddMonths(1);
    }
    
    public override string ToString() => $"[CREDIT_CARD] ({ValidUntil:yyyy-MM-dd})";
}