using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record DiscriminantComplexZero : IDiscriminant, IComplex, ISingular
{
    public Complex Value => Complex.Zero;
}