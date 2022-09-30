namespace Lab4;

public class Elephant: Animal
{
    public string Information
    {
        get => "Elephants are the largest existing land animals.";
    }
    public override void Move()
    {
        Console.WriteLine("Elephant walks");
    }

    public override void Eat()
    {
        Console.WriteLine("Puts the food in it's mouse with the trunc");
    }
}