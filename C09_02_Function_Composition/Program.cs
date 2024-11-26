using C09_02_Function_Composition.Functions;
using C09_02_Function_Composition.Models;

namespace C09_02_Function_Composition;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person()
            .WithAge(50)
            .WithName("John")
            .WithLength(1.87m)
            .WithEyeColour("Blue");
        
        Console.WriteLine($"Hello, {person}!");
    }
}