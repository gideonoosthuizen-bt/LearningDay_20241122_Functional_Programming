namespace C03_01_First_Order_Only.Extensions;

public static class ConsoleExtensions
{
    public static string Join(this IEnumerable<string> values, string separator) =>
        string.Join(separator, values);
    
    public static void WriteLine(this string value) =>
        Console.WriteLine(value);
}