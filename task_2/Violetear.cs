namespace Lab4;

public class Violetear: Animal
{

    public string Information
    {
        get => "The violetears are hummingbirds of the genus Colibri";
    }
     public override void Move()
    {
        Console.WriteLine("Violetear flies");
    }

     public override void Eat()
     {
         Console.WriteLine("Drinks nectar from with the trunc");
     }
}