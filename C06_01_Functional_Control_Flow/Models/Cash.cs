using C06_01_Functional_Control_Flow.Markers;

namespace C06_01_Functional_Control_Flow.Models;

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