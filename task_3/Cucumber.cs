namespace Lab_4;

public class Cucumber: Vegitable
{
    private TypeOfCucumber sort;

    public TypeOfCucumber Sort
    {
        get { return sort; }
    }
    
    // Calculates how much tomatoes in gram are needed for the salad
    public double ToMakeSalad(double salad)
    {
        return (salad.Persentage(40));
    }

    public Cucumber(string name, string color, double kilocalories, TypeOfCucumber sort) : base(name, color, kilocalories)
    {
        this.sort = sort; 
    }

    // Types of tomatoes 
    public enum TypeOfCucumber { Armenian, Garden, Gherkins } 
}

