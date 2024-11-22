namespace C06_01_Functional_Control_Flow.Common;

public abstract class Option<T>
{
    public static implicit operator Option<T>(T value) => new Some<T>(value);
    public static implicit operator Option<T>(None _) => new None<T>();
}