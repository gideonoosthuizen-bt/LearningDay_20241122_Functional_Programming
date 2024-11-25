using C03_01_First_Order_Only.Extensions;
using C03_01_First_Order_Only.Functions;
using C03_01_First_Order_Only.Models;

namespace C03_01_First_Order_Only;

class Program
{
    static void Main(string[] args)
    {
        PrintPrices(
            new Product("Steering wheel",
                new Amount(20m, new Currency("USD"))),
            10, 19);

        Console.ReadLine();
    }

    static void PrintPrices(Product product, int from, int to) =>
        Enumerable.Range(from, to - from + 1)
            .Select(quantity => (quantity, product.Buy(quantity).TotalPrice))
            .Select(tuple => $"{tuple.quantity} x {product.Name} = {tuple.TotalPrice}")
            .Join(Environment.NewLine)
            .WriteLine();
}