using C08_02_Immutable_Collections.Common;

namespace C08_02_Immutable_Collections.Extensions;

public static class ReiterableExtensions
{
    public static Reiterable<T> AsReiterable<T>(this IEnumerable<T> source) =>
        Reiterable<T>.From(source);
}