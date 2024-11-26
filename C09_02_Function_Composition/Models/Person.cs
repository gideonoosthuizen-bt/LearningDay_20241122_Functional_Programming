namespace C09_02_Function_Composition.Models;

public record Person
{
    public string Name { get; }
    public int Age { get; }
    public string EyeColour { get; }
    public decimal Length { get; }

    public Person()
    {
    }
    
    public Person(string name, int age, string eyeColour, decimal length)
    {
        Name = name;
        Age = age;
        EyeColour = eyeColour;
        Length = length;
    }

    public override string ToString() => $"NAME: {Name}\r\nAGE: {Age}\r\nEYE COLOUR: {EyeColour}\r\nLENGTH: {Length}";
}