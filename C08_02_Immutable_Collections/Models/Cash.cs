using C08_02_Immutable_Collections.Markers;

namespace C08_02_Immutable_Collections.Models;

public record Cash : IMoney
{
    public Amount Value { get; }
    
    public Cash(Amount value)
    {
        ArgumentNullException.ThrowIfNull(value, nameof(value));
        ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0, nameof(value.Value));
        
        Value = value;
    }

    public override string ToString() => $"[CASH] {Value}";
}