using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Lab_4;

public class Salad
{
    private Cucumber cucumbers;
    private Tomato tomatoes;
    private Onion onions;
    
    private int saladAmount  = 500; // in grams

    public Salad(Cucumber cucumbers, Tomato tomatoes, Onion onions)
    {
        this.cucumbers = cucumbers;
        this.tomatoes = tomatoes;
        this.onions = onions;
    }

    public void ListIngredients()
    {
        Console.WriteLine($"Cucumber: {cucumbers.Sort} in amount of {cucumbers.ToMakeSalad(saladAmount)} g");
        Console.WriteLine($"Tomatoes: {tomatoes.Sort} in amount of {tomatoes.ToMakeSalad(saladAmount)} g"); 
        Console.WriteLine($"Onions: {onions.Sort} in amount of {onions.ToMakeSalad(saladAmount)} g");
    }

    public void ListInDebug()
    {
        Debug.WriteLine($"Cucumber:");
        DescribeProperties(cucumbers);
        Debug.WriteLine($"Tomato:");
        DescribeProperties(tomatoes);
        Debug.WriteLine($"Onion:");
        DescribeProperties(onions);
    }

    private static void DescribeProperties(Object obj)
    {
        foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
        {
            string name = descriptor.Name;
            object value = descriptor.GetValue(obj);
            Debug.WriteLine("{0}={1}", name, value);
        }
        Debug.WriteLine("");
    }
}