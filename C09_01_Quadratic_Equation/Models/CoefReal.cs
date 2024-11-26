using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record CoefReal : ICoef, IReal
{
    public decimal A { get; }
    public decimal B { get; }
    public decimal C { get; }
    
    public CoefReal(decimal a, decimal b, decimal c)
    {
        A = a;
        B = b;
        C = c;
    }
}