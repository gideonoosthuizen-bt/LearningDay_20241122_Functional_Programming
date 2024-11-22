namespace C06_01_Functional_Control_Flow.Common;

public class Some<T> : Option<T>
{
    private T Content { get; }
    
    public Some(T content) => Content = content;

    public static implicit operator T(Some<T> value) => value.Content;
}