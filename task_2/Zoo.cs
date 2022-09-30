namespace Lab4;
public class Zoo
{
    private Animal? animalThatWalks;
    private Animal? animalThatFlies;
    private Animal? animalThatSwims;

    private Animal?[] AnimalsInTheZoo
    {
        get { return new Animal?[] { animalThatWalks, animalThatSwims, animalThatFlies }; }
    } 
    public Zoo (Animal animalOne, Animal animalTwo)
    {
        Animal[] argumentsArray = {animalOne, animalTwo};
        
        foreach (var Type in argumentsArray)
        {
            switch (Type)
            {
                case Elephant:
                    animalThatWalks = Type;
                    break;
                case Violetear:
                    animalThatFlies = Type;
                    break; 
                case Dolphin:
                    animalThatSwims = Type;
                    break;
            }  
        }
    }
    
    public Zoo(Animal animalThatWalks, Animal animalThatFlies, Animal animalThatSwims)
    
    {
        this.animalThatWalks = animalThatWalks;
        this.animalThatFlies = animalThatFlies;
        this.animalThatSwims = animalThatSwims;
    }

    public void TellAboutAnimalsInTheZoo()
    {
        foreach (var animal in AnimalsInTheZoo)
        {
            if (animal != null)
            {
                switch (animal) 
                {
                    case Dolphin dolphin:
                        Dolphin swimingAnimal = dolphin;
                        Console.WriteLine(swimingAnimal.Information);
                        break;
                    case Elephant elephant:
                        Elephant walkingAnimal = elephant;
                        Console.WriteLine(walkingAnimal.Information);
                        break;
                    case Violetear violetear:
                        Violetear flyingAnimal = violetear;
                        Console.WriteLine(flyingAnimal.Information);
                        break;
                }
            }
        }
    }
}