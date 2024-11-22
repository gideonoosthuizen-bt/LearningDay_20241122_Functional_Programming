namespace C05_02_Equivalence_Relations;

// This class is used to demonstrate equivalence relations
// Especially in the context of value object equality
// Practically it is much easier to just make Currency a record
public class Currency
{
    protected readonly string _symbol;

    protected Currency(string symbol)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));
        
        _symbol = symbol;
    }
    
    public static Currency USD => new("USD");
    public static Currency EUR => new("EUR");
    
    // Overriding the ToString method to return the symbol is a cosmetic practice
    // But whichever property is used to identify the object is a good suitor
    // for the hash code override as well (typically)
    public override string ToString() => _symbol;

    // Using the hash code of the symbol (string) is a good strategy
    // as string hash codes are well distributed and unique
    public override int GetHashCode()
    {
        return _symbol.GetHashCode();
    }
    
    // When overriding the hash code, the equals method should also be overridden
    // by comparing the hash codes of the base objects. This way, no unexpected
    // comparison results will occur when using the object separately or in collections
    
    public override bool Equals(object? obj) => GetHashCode() == obj?.GetHashCode();

    // Overriding the == and != operators by referring to the Equals method
    // is a common practice in C# to ensure that the operators are consistent
    // In reality this means that equivalence and equality are the same for this model
    // Comment these out to see the difference in the output
    
    public static bool operator ==(Currency a, Currency b) => a.Equals(b);
    public static bool operator !=(Currency a, Currency b) => !(a == b);
}