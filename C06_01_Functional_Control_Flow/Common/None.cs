namespace C06_01_Functional_Control_Flow.Common;

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