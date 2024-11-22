using C03_02_Higher_Order.Extensions;
using C03_02_Higher_Order.Functions;
using C03_02_Higher_Order.Models;

namespace C03_02_Higher_Order;

class Program
{
    static void Main(string[] args)
    {
        var product = new Product("Steering wheel",
            new Amount(20m, new Currency("USD")));
        
        PrintPrices(product, 10, 19, product.PriceFor());

        Console.ReadLine();
    }

    static void PrintPrices(Product product, int from, int to, Func<int, Amount> priceFor) =>
        Enumerable.Range(from, to - from + 1)
            .Select(quantity => (Quantity: quantity, Price: priceFor(quantity)))
            .Select(tuple => $"{tuple.Quantity} x {product.Name} = {tuple.Price}")
            .Join(Environment.NewLine)
            .WriteLine();
}