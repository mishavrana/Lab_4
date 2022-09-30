namespace Lab4;

public class Dolphin: Animal
{
    public string Information
    {
       get => "A dolphin is an aquatic mammal";
    }
    public override void Move()
    {
        Console.WriteLine("Dolphin swims");
    }

    public override void Eat()
    {
        Console.WriteLine("Catches the food in water");
    }
}