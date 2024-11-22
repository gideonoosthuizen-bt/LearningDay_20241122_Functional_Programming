using C03_03_Hiding_Implementation.Functions;
using C03_03_Hiding_Implementation.Models;

namespace C03_03_Hiding_Implementation.Extensions;

public static class DependencyExtensions
{
    public static (Func<int, Amount> PriceFor, Func<Amount, Amount> TaxFor, Func<int, int, Func<int, Amount>, string> PrintFor) GetDependencies(this Product product) =>
        (product.PriceFor(product.TaxFor()), product.TaxFor(), product.PrintFor());
}