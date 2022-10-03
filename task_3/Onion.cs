namespace Lab_4;

public class Onion: Vegitable
{
    private TypeOfOnion sort;

    public TypeOfOnion Sort
    {
        get { return sort; }
    }
    
    // Calculates how much tomatoes in gram are needed for the salad
    public double ToMakeSalad(double salad)
    {
        return (salad.Persentage(10));
    }

    public Onion(string name, string color, double kilocalories, TypeOfOnion sort) : base(name, color, kilocalories)
    {
        this.sort = sort; 
    }

    // Types of tomatoes 
    public enum TypeOfOnion{ Armenian, Garden, Gherkins } 
}