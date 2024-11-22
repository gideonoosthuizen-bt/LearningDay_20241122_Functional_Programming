using C08_01_Immutable_Sequences.Markers;

namespace C08_01_Immutable_Sequences.Models;

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