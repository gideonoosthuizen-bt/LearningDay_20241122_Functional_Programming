namespace C05_02_Equivalence_Relations;

public sealed class Euro : Currency
{
    private readonly string _country;

    private Euro(string country) : base("EUR")
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(country, nameof(country));

        _country = country;
    }
    
    public static Euro FromGermany => new("Germany");
    public static Euro FromNetherlands => new("Netherlands");
    
    public override string ToString() => $"[{_country}] {_symbol}";
    
    public override int GetHashCode() => _symbol.GetHashCode() ^ _country.GetHashCode();
}