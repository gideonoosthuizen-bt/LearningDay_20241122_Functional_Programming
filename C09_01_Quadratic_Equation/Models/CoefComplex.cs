using System.Numerics;
using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record CoefComplex : ICoef, IComplex
{
    public Complex A { get; }
    public Complex B { get; }
    public Complex C { get; }
    
    public CoefComplex(Complex a, Complex b, Complex c)
    {
        A = a;
        B = b;
        C = c;
    }
}