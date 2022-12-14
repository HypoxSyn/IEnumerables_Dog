
using System.Collections;

DogShelter shelter = new();

foreach (Dog dog in shelter)
{
    if (!dog.IsNaughtyDog)
    {
        dog.GiveTreat(2);
    }
    else
    {
        dog.GiveTreat(1);
    }

}

class Dog
{
    public string Name { get; set; }

    public bool IsNaughtyDog { get; set; }

    public Dog(string name, bool isNaughtyDog)
    {
        this.Name = name;
        this.IsNaughtyDog = isNaughtyDog;
    }

    public void GiveTreat(int numberOfTreats)
    {

        Console.WriteLine($"Dog: {Name} said woof {numberOfTreats} times!");
    }
}

class DogShelter : IEnumerable<Dog>
{
    public List<Dog> dogs;


    public DogShelter()
    {
        dogs = new List<Dog>()
        {
            new Dog("Casper", false),
            new Dog("Sif", true),
            new Dog("Oreo", false),
            new Dog("Ted", false)
        };


    }

    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
    {
        return dogs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}