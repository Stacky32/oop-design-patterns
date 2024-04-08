using Library.GangOfFour.Creational.AbstractFactory.Animals;
using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory.Factories;

public class Europe : IContinentFactory
{
    public ICarnivore CreateCarnivore() => new Lion();

    public IHerbivore CreateHerbivore() => new Bison();
}