namespace C08_01_Immutable_Sequences.Common;

public class None<T> : Option<T>
{
}

public class None
{
    public static None Value { get; } = new None();

    private None()
    {
    }
}