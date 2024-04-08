using Library.GangOfFour.Creational.AbstractFactory.Animals;
using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory.Factories;

public class Africa : IContinentFactory
{
    public ICarnivore CreateCarnivore() => new Lion();

    public IHerbivore CreateHerbivore() => new Wildebeest();
}