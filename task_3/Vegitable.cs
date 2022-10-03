namespace Lab_4;

public class Vegitable
{
    private string name;
    private string color;
    
    private double kilocalories;

    public string Name
    {
        get { return name; }
    }

    public string Color
    {
        get { return color;  }
    }

    public double Kilocalries
    {
        get { return kilocalories; }
    }

    public Vegitable(string name, string color, double kilocalories)
    {
        this.name = name;
        this.color = color;
        this.kilocalories = kilocalories; 
    }
}

