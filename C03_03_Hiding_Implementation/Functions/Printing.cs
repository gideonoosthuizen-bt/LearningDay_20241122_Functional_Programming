using C03_03_Hiding_Implementation.Extensions;
using C03_03_Hiding_Implementation.Models;

namespace C03_03_Hiding_Implementation.Functions;

public static class Printing
{
    public static Func<int, int, Func<int, Amount>, string> PrintFor(this Product product) =>
        (from, to, priceFor) => Enumerable.Range(from, to - from + 1)
            .Select(quantity => (Quantity: quantity, Price: priceFor(quantity)))
            .Select(tuple => $"{tuple.Quantity} x {product.Name} = {tuple.Price}")
            .Join(Environment.NewLine);
}