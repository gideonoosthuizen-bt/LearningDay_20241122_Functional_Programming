using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record RootComplexPair : IRoot, IComplex, IPair
{
    public Complex X1 { get; }
    public Complex X2 { get; }

    public RootComplexPair(Complex x1, Complex x2)
    {
        X1 = x1;
        X2 = x2;
    }
}