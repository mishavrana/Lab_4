namespace Lab_4;

public class Tomato: Vegitable
{
    private TypeOfTomato sort;

    public TypeOfTomato Sort
    {
        get { return sort; }
    }
    
    // Calculates how much tomatoes in gram are needed for the salad
    public double ToMakeSalad(double salad)
    {
        return (salad.Persentage(50));
    }

    public Tomato(string name, string color, double kilocalories, TypeOfTomato sort) : base(name, color, kilocalories)
    {
        this.sort = sort; 
    }

    // Types of tomatoes 
    public enum TypeOfTomato { Chery, Roma, Grape }
}

