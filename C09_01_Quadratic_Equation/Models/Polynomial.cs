using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record Polynomial
{
    public ICoef Coef { get; }
    public IRoot Root { get; }
    
    public Polynomial(ICoef coef, IRoot root)
    {
        Coef = coef;
        Root = root;
    }
}