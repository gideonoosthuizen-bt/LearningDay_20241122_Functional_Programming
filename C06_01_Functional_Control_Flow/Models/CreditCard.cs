using C06_01_Functional_Control_Flow.Markers;

namespace C06_01_Functional_Control_Flow.Models;

public record CreditCard : IMoney
{
    public DateOnly ValidUntil { get; }

    public CreditCard(Month validThru)
    {
        ValidUntil = ((DateOnly)validThru).AddMonths(1);
    }
    
    public override string ToString() => $"[CREDIT_CARD] ({ValidUntil:yyyy-MM-dd})";
}