namespace C08_02_Immutable_Collections.Common;

public class Some<T> : Option<T>
{
    private T Content { get; }
    
    public Some(T content) => Content = content;

    public static implicit operator T(Some<T> value) => value.Content;
}