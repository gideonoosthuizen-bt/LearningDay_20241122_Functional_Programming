using C08_02_Immutable_Collections.Common;

namespace C08_02_Immutable_Collections.Extensions;

public static class OptionExtensions
{
    public static IEnumerable<T> SelectOptional<T> (this IEnumerable<T> source, Func<T, Option<T>> selector) 
        where T : class
    {
        foreach (var item in source)
        {
            var option = selector(item); 
            var result = option switch
            {
                Some<T> some => (T)some,
                None<T> none => null,

                _ => throw new InvalidOperationException($"Unknown option type: {option.GetType()}")
            };

            if (result is null)
            {
                continue;
            }

            yield return result;
        }
    }
}