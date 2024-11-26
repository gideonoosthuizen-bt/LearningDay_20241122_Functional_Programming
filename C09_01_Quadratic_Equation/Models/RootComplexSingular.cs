using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record RootComplexSingular : IRoot, IComplex, ISingular
{
    public Complex X { get; }

    public RootComplexSingular(Complex x)
    {
        X = x;
    }
}