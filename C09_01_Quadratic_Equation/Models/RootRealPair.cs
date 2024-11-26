using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record RootRealPair : IRoot, IReal, IPair
{
    public decimal X1 { get; }
    public decimal X2 { get; }

    public RootRealPair(decimal x1, decimal x2)
    {
        X1 = x1;
        X2 = x2;
    }
}