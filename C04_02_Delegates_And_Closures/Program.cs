namespace C04_02_Delegates_And_Closures;

class Program
{
    static void Work(Func<int, int> scale)
    {
        var y = scale(5);
        Console.WriteLine(y); // 10 or 15?
    }
    
    static void Main_(string[] args)
    {
        // Closure (informal)
        int factor = 2; 
        int scale(int x) => factor * x;

        factor = 3;
        Work(scale);

        Console.ReadLine();
    }
    
    class Closure
    {
        // In production code, try to avoid mutable state in closures
        public int Environment;
        public int Function(int arg) => Environment * arg;
    }
    
    static void Main(string[] args)
    {
        // Closure (formal)
        var closure = new Closure { Environment = 2 };

        closure.Environment = 3;
        Work(closure.Function);
        
        Console.ReadLine();
    }
}