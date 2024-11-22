using C03_03_Hiding_Implementation.Extensions;
using C03_03_Hiding_Implementation.Models;

"Printing prices...".WriteLine();
        
string.Empty.WriteLine();
        
new Product("Steering wheel",
        new Amount(20m, new Currency("USD")))
    .GetDependencies()
    .Map(dependencies =>
        dependencies.PrintFor(10, 19, dependencies.PriceFor)).WriteLine();
        
Console.ReadLine();