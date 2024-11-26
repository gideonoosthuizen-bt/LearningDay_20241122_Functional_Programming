using System.Numerics;
using C09_01_Quadratic_Equation.Markers;
using C09_01_Quadratic_Equation.Models;

namespace C09_01_Quadratic_Equation.Functions;

public static class QuadraticFunctions
{
    private static decimal _calculateRealDiscriminantValue(decimal a, decimal b, decimal c) => b * b - 4 * a * c;
    private static Complex _calculateComplexDiscriminantValue(Complex a, Complex b, Complex c) => b * b - 4 * a * c;

    private static IDiscriminant _determineRealDiscriminant(decimal discriminantValue) => discriminantValue switch
    {
        > 0 => new DiscriminantReal(discriminantValue),
        0 => new DiscriminantRealZero(),
        
        _ => new DiscriminantNone()
    };
    
    private static IDiscriminant _determineComplexDiscriminant(Complex discriminantValue) => discriminantValue switch
    {
        { Real: 0 } => new DiscriminantComplexZero(),
        
        _ => new DiscriminantComplex(discriminantValue),
    };
    
    private static IDiscriminant _calculateDiscriminant(ICoef coef) => coef switch
    {
        CoefReal { A: var a, B: var b, C: var c } => _determineRealDiscriminant(_calculateRealDiscriminantValue(a, b, c)),
        CoefComplex { A: var a, B: var b, C: var c } => _determineComplexDiscriminant(_calculateComplexDiscriminantValue(a, b, c)),

        _ => throw new ArgumentException("Invalid type of coef")
    };

    private static IRoot _calculateRoot(this ICoef coef) => _calculateDiscriminant(coef) switch
    {
        DiscriminantNone => new RootNone(),

        DiscriminantRealZero when coef is CoefReal { A: var a, B: var b } => new RootRealSingular(-b / (2 * a)),
        DiscriminantComplexZero when coef is CoefComplex { A: var a, B: var b } => new RootComplexSingular(-b / (2 * a)),

        DiscriminantReal { Value: var d } when coef is CoefReal { A: var a, B: var b } => a switch
        {
            0 => new RootNone(),
            
            _ => new RootRealPair(
                (-b + (decimal)Math.Sqrt((double)d)) / (2 * a),
                (-b - (decimal)Math.Sqrt((double)d)) / (2 * a)
            )
        },

        DiscriminantComplex { Value: var d } when coef is CoefComplex { A: var a, B: var b } => a switch
        {
            { Real: 0, Imaginary: 0 } => new RootNone(),
            
            _ => new RootComplexPair(
                (-b + Complex.Sqrt(d)) / (2 * a),
                (-b - Complex.Sqrt(d)) / (2 * a)
            )
        },

        _ => throw new ArgumentException("Invalid type of discriminant")
    };
    
    public static Polynomial Calculate(this ICoef coef) => new (coef, coef._calculateRoot());
}