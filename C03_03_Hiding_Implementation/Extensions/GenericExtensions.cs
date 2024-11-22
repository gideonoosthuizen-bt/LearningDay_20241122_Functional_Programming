namespace C03_03_Hiding_Implementation.Extensions;

public static class GenericExtensions
{
    public static TResult Map<T, TResult>(this T value, Func<T, TResult> map) => map(value);
}