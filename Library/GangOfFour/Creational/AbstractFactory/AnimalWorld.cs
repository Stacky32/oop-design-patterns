using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory;

public class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
{
    private readonly ICarnivore _carnivore;
    private readonly IHerbivore _herbivore;

    public AnimalWorld()
    {
        var factory = new T();

        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }

    public string RunFoodChain()
    {
        return _carnivore.Eat(_herbivore);
    }
}