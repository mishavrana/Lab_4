namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        DerivedClass derivedClass = new DerivedClass(); 
        derivedClass.WriteInDebug("Message with number", 20);
    }
}