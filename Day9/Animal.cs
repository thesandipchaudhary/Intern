class Animal
{
    internal string species;
    internal int age;
    internal int weight;
    internal string color;
    internal int leg;
    public void Animaldetails()
    {
        Console.WriteLine($"The animal is a {species}");
        Console.WriteLine($"The age of {species} is {age} year");
        Console.WriteLine($"The weight of {species}  is {weight} kg");
        Console.WriteLine($"The color of {species} is {color}");
        Console.WriteLine($"The {species} has {leg} legs");
    }
}