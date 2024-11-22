using System.Collections;

namespace C08_01_Immutable_Sequences.Common;

public class Reiterable<T> : IEnumerable<T>
{
    private IEnumerable<T> _data { get; }

    private Reiterable(IEnumerable<T> data)
    {
        _data = data;
    }

    public static Reiterable<T> From(IEnumerable<T> data) => data switch
    {
        List<T> list => list,
        T[] array => array,
        Reiterable<T> reiterable => reiterable,
        
        _ => new Reiterable<T>(data.ToList())
    };

    public static implicit operator Reiterable<T>(List<T> data) => new(data);
    public static implicit operator Reiterable<T>(T[] data) => new(data);

    public IEnumerator<T> GetEnumerator() => _data.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}