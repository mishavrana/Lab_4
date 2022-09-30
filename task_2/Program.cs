namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Dolphin dolphin = new Dolphin();
        Elephant elephant = new Elephant();

        Zoo kyivZoo = new Zoo(dolphin, elephant);
        kyivZoo.TellAboutAnimalsInTheZoo();
    }
}