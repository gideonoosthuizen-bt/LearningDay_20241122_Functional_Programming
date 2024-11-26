using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record DiscriminantReal : IDiscriminant, IReal
{
    public decimal Value { get; }

    public DiscriminantReal(decimal value)
    {
        Value = value;
    }
}