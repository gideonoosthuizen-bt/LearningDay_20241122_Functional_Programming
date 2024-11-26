using C09_01_Quadratic_Equation.Markers;
using C09_01_Quadratic_Equation.Models;

namespace C09_01_Quadratic_Equation.Functions;

public static class PolyFunctions
{
    public static PolynomialSet Add(this PolynomialSet set, ICoef coef) => new(set.Polynomials.Add(coef.Calculate()));
}