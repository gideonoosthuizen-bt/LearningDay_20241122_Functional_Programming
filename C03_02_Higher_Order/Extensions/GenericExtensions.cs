namespace C03_02_Higher_Order.Extensions;

public static class GenericExtensions
{
    public static TResult Map<T, TResult>(this T value, Func<T, TResult> map) => map(value);
}