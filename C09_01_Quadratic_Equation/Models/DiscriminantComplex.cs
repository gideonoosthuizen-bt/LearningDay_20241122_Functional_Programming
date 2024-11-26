using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record DiscriminantComplex : IDiscriminant, IComplex
{
    public Complex Value { get; }
    
    public DiscriminantComplex(Complex value)
    {
        Value = value;
    }
}