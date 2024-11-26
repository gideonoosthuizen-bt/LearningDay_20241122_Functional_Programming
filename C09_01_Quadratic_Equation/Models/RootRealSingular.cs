using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record RootRealSingular : IRoot, IReal, ISingular
{
    public decimal X { get; }

    public RootRealSingular(decimal x)
    {
        X = x;
    }
}