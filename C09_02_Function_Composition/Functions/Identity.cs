using C09_02_Function_Composition.Models;

namespace C09_02_Function_Composition.Functions;

public static class Identity
{
    public static Person WithName(this Person person, string name) => new Person(name, person.Age, person.EyeColour, person.Length);
    public static Person WithAge(this Person person, int age) => new Person(person.Name, age, person.EyeColour, person.Length);
    public static Person WithEyeColour(this Person person, string eyeColour) => new Person(person.Name, person.Age, eyeColour, person.Length);
    public static Person WithLength(this Person person, decimal length) => new Person(person.Name, person.Age, person.EyeColour, length);
}