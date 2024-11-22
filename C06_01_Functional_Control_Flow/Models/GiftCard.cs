using C06_01_Functional_Control_Flow.Markers;

namespace C06_01_Functional_Control_Flow.Models;

public record GiftCard : IMoney
{
    public Amount Value { get; }
    public DateOnly ValidUntil { get; }
    
    public GiftCard(Amount value, DateOnly validThru)
    {
        ArgumentNullException.ThrowIfNull(value, nameof(value));
        ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0, nameof(value.Value));
        
        ArgumentNullException.ThrowIfNull(validThru, nameof(validThru));
        ArgumentOutOfRangeException.ThrowIfEqual(validThru, DateOnly.MinValue, nameof(validThru));
        
        Value = value;
        ValidUntil = validThru.AddDays(1);
    }
    
    public override string ToString() => $"[GIFT_CARD] {Value} ({ValidUntil:yyyy-MM-dd})";
}