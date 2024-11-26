using System.Numerics;
using C09_01_Quadratic_Equation.Functions;
using C09_01_Quadratic_Equation.Models;

namespace C09_01_Quadratic_Equation;

class Program
{
    static void Main(string[] args)
    {
        var x = new PolynomialSet()
            .Add(new CoefComplex(new Complex(3, -5), new Complex(-2, 0), new Complex(1, 1)))
            .Add(new CoefReal(1, 6, 2))
            .Add(new CoefReal(0, 6, 2))
            .Add(new CoefReal(1, 2, 1))
            .Add(new CoefReal(5, 2, 7))
            .Add(new CoefComplex(new Complex(5,0), new Complex(2,0), new Complex(7,0)))
            .Add(new CoefComplex(new Complex(0, 0), new Complex(2, 1), new Complex(3, 5)));
        
        Console.WriteLine("Hello, World!");
    }
}