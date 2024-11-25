namespace C05_01_Hashing_Principles;

// Basic explanation for hashing tables
class Element<T>
{
    public T Content { get; set; }
    public Element<T>? Next { get; set; }
}

static class Hashing
{
    // Hash code must always be deterministic and constant for any given object
    // otherwise object comparison will not work as expected and entries
    // might get lost in the hash table.
    private static int _getHashCode<T>(T value)
    {
        return value?.GetHashCode() ?? 0;
    }
    
    public static void Add<T>(this Element<T>[] set, T value)
    {
        // Determine hash code for value
        var hashCode = _getHashCode(value);
        
        // Determine entry in set
        var entry = hashCode % set.Length;
        if(entry < 0) entry += set.Length;

        Console.WriteLine($"Adding {value} ({hashCode:X8}) to set[{entry}].");
        
        // Create new element and add it to the set
        // using chaining to handle hash collisions
        var element = new Element<T> { Content = value, Next = set[entry] };
        set[entry] = element;
    }

    public static bool Contains<T>(this Element<T>[] set, T value)
    {
        // Determine hash code for value
        var hashCode = _getHashCode(value);
        
        // Determine entry in set
        var entry = hashCode % set.Length;
        if(entry < 0) entry += set.Length;
        
        Console.WriteLine($"Checking if {value} ({hashCode:X8}) is in set[{entry}].");
        
        // Start at the beginning of the chain and iterate through
        // all elements in the chain to find the value
        for(var current = set[entry]; current != null; current = current.Next)
        {
            var currentHashCode = _getHashCode(current.Content);
            if(currentHashCode == hashCode)
            {
                return true;
            }
        }
        
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*
        var set = new HashSet<int>();
        */
        
        var set = new Element<string>[7];

        set.Add("11");
        set.Add("22");
        set.Add("33");
        set.Add("44");
        set.Add("55");
        set.Add("66");
        set.Add("77");
        set.Add("88");
        set.Add("99");
        
        if (set.Contains("33"))
        {
            Console.WriteLine("Suspect (33) is in the set.");
        }
        
        Console.WriteLine("Hello, World!");
    }
}