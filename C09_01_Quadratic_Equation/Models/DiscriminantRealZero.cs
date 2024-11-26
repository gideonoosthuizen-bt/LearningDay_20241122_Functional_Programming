using C09_01_Quadratic_Equation.Markers;

namespace C09_01_Quadratic_Equation.Models;

public record DiscriminantRealZero : IDiscriminant, ISingular
{
    public decimal Value => 0m;
}