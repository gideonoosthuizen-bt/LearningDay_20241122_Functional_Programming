namespace C08_01_Immutable_Sequences.Common;

public abstract class Option<T>
{
    public static implicit operator Option<T>(T value) => new Some<T>(value);
    public static implicit operator Option<T>(None _) => new None<T>();
}