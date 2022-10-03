namespace Lab_4;

class Program
{
    private static Tomato tomato = new Tomato
    (
        "tomato", 
        "red", 
        120, 
        Tomato.TypeOfTomato.Chery
    );
    private static Cucumber cucumber = new Cucumber
    (
        "cucumber", 
        "green", 
        90, 
        Cucumber.TypeOfCucumber.Garden
    );

    private static Onion onion = new Onion
    (
        "onion", 
        "purple", 
        20, 
        Onion.TypeOfOnion.Armenian
    ); 
    
    private static Salad salad = new Salad(cucumber, tomato, onion);
    
    static void Main(string[] args)
    {
        salad.ListIngredients();
        salad.ListInDebug();
    }
}

