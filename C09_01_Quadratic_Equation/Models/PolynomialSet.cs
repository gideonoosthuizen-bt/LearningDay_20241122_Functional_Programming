using System.Collections.Immutable;
using C09_01_Quadratic_Equation.Functions;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record PolynomialSet
{
    public ImmutableList<Polynomial> Polynomials { get; } = ImmutableList<Polynomial>.Empty;

    public PolynomialSet()
    {
    }

    public PolynomialSet(ImmutableList<Polynomial> polynomials)
    {
        Polynomials = polynomials;
    }
}