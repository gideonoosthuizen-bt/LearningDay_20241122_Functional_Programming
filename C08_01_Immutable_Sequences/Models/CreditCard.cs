using C08_01_Immutable_Sequences.Markers;

namespace C08_01_Immutable_Sequences.Models;

public record CreditCard : IMoney
{
    public DateOnly ValidUntil { get; }

    public CreditCard(Month validThru)
    {
        ValidUntil = ((DateOnly)validThru).AddMonths(1);
    }
    
    public override string ToString() => $"[CREDIT_CARD] ({ValidUntil:yyyy-MM-dd})";
}