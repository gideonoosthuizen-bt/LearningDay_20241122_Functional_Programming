namespace C08_02_Immutable_Collections.Common;

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