namespace C05_02_Equivalence_Relations;

class Program
{
    static void IsEquivalentTo(Currency a, Currency b)
    {
        var rel = a.Equals(b) ? "is equivalent to" : "is not equivalent to";
        var rev = b.Equals(a) ? "is equivalent to" : "is not equivalent to";
        
        Console.WriteLine($"{a} {rel} {b}");
        Console.WriteLine($"{b} {rev} {a}");
        Console.WriteLine("---");
    }
    
    static void IsEqualTo(Currency a, Currency b)
    {
        var rel = a == b ? "is equal to" : "is not equal to";
        var rev = b == a ? "is equal to" : "is not equal to";
        
        Console.WriteLine($"{a} {rel} {b}");
        Console.WriteLine($"{b} {rev} {a}");
        Console.WriteLine("---");
    }
    
    static void Main(string[] args)
    {
        var a = Currency.EUR;
        var b = Currency.EUR;
        var c = Currency.USD;
        var d = Euro.FromNetherlands;
        var e = Euro.FromGermany;
        var f = Euro.FromNetherlands;
        
        IsEquivalentTo(a, b);
        IsEquivalentTo(a, c);
        IsEquivalentTo(b, c);
        
        IsEquivalentTo(d, e);
        IsEquivalentTo(d, f);
        IsEquivalentTo(e, f);

        IsEquivalentTo(a, d);
        IsEquivalentTo(a, e);
        IsEquivalentTo(a, f);
        
        IsEqualTo(a, b);
        IsEqualTo(a, c);
        IsEqualTo(b, c);
        
        IsEqualTo(d, e);
        IsEqualTo(d, f);
        IsEqualTo(e, f);

        IsEqualTo(a, d);
        IsEqualTo(a, e);
        IsEqualTo(a, f);
    }
} 