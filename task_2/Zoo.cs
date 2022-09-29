namespace Lab4;

// public class Zoo<AnimalThatWalks, AnimalThatSwims, AnimalThatFlies> 
//     where AnimalThatWalks : new() 
//     where AnimalThatSwims : new()
//     where AnimalThatFlies : new()
// {
//     private AnimalThatWalks elephant = new AnimalThatWalks();
//     private AnimalThatSwims dolphin = new AnimalThatSwims();
//     private AnimalThatFlies violetear = new AnimalThatFlies();
//
// }

public class Zoo
{
    private Animal? animalThatWalks;
    private Animal? animalThatFlies;
    private Animal? animalThatSwims;

    public Zoo(Animal animalThatWalks, Animal animalThatFlies)
    {
        this.animalThatWalks = animalThatWalks;
        this.animalThatFlies = animalThatFlies;
    }

    public Zoo(Animal animalThatWalks, Animal animalThatFlies, Animal animalThatSwims)
    {
        this.animalThatWalks = animalThatWalks;
        this.animalThatFlies = animalThatFlies;
        this.animalThatSwims = animalThatSwims;
    }
}