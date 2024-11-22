namespace C08_01_Immutable_Sequences.Common;

public class Some<T> : Option<T>
{
    private T Content { get; }
    
    public Some(T content) => Content = content;

    public static implicit operator T(Some<T> value) => value.Content;
}