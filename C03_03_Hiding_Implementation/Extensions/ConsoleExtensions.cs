namespace C03_03_Hiding_Implementation.Extensions;

public static class ConsoleExtensions
{
    public static string Join(this IEnumerable<string> values, string separator) =>
        string.Join(separator, values);
    
    public static void WriteLine(this string value) =>
        Console.WriteLine(value);
}