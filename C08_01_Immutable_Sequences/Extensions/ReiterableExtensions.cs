using C08_01_Immutable_Sequences.Common;

namespace C08_01_Immutable_Sequences.Extensions;

public static class ReiterableExtensions
{
    public static Reiterable<T> AsReiterable<T>(this IEnumerable<T> source) =>
        Reiterable<T>.From(source);
}